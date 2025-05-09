/* Create database if it does not exist */
if not exists (select * from sys.databases where name = 'GameStore')
begin
	create database [GameStore]
end;
go   -- 'GO' tells SQL Server to execute the above batch of commands before moving to the next one

use [GameStore]

create table dbo.Users
(
    UserId int primary key IDENTITY(1,1),
    Username varchar(50) not null unique,
    UserPassword varchar(64) not null, 
    Email varchar(255) not null unique,
    UserRole varchar(20) not null
        constraint chk_UserRole check (UserRole IN ('admin','customer')),
    CreatedAt datetime2 not null
        constraint df_Users_CreatedAt default SYSUTCDATETIME(),
	shippingAddress varchar(50) not null
		constraint DF_Users_ShippingAddress default 'Not Provided'
);

create table dbo.genre (
    genreid int primary key identity(1,1),
    genrename varchar(50) not null unique
);
create table dbo.platform (
    platformid int primary key identity(1,1),
    platformname varchar(50) not null unique
);
create table dbo.games (
    gameid int primary key identity(1,1),
    gametitle varchar(50) not null unique,
    description varchar(255),
    price decimal(10, 2) not null
);

create table dbo.games_genre(
	gameid int not null, 
	genreid int not null, 
	constraint fk_gamesgenre_id foreign key (gameid) references dbo.games(gameid) on delete cascade,
	constraint fk_genre_id foreign key (genreid) references dbo.genre(genreid),
	primary key (gameid, genreid)
);

create table dbo.games_platform(
	gameid int not null, 
	platformid int not null, 
	constraint fk_gamesplatform_id foreign key (gameid)  references dbo.games(gameid) on delete cascade,
	constraint fk_platform_id foreign key (platformid) references dbo.platform(platformid),
	primary key (gameid, platformid)
);


create table dbo.Inventory(
	inventoryId int primary key identity(1,1),
	gameId int not null, 
	quantity int not null
	    constraint chk_Inventory_quantity check (quantity >= 0),
	constraint fk_inventoryGame_id foreign key (gameId) references dbo.games(gameid) on delete cascade
);

create table dbo.Orders(
	orderId int primary key identity(1,1),
	userId int not null,
	orderDate datetime2 not null
	    constraint df_Orders_orderDate default SYSUTCDATETIME(),
	totalAmount decimal(10,2) not null
	    constraint chk_Orders_totalAmount check (totalAmount >= 0),
	status varchar(50) not null
	    constraint chk_Orders_status check (status in ('pending', 'delivered', 'cancelled')),
	shippingAddress varchar(255) null,
	trackingNumber varchar(100) null,
	constraint fk_ordersUser_id foreign key (userId) references dbo.Users(UserId)
);

create table dbo.OrderDetails(
	orderDetailId int primary key identity(1,1),
	orderId int not null,
	gameId int not null,
	quantity int not null
	    constraint chk_OrderDetails_quantity check (quantity > 0),
	pricePerUnit decimal(10,2) not null
	    constraint chk_OrderDetails_pricePerUnit check (pricePerUnit >= 0),
	constraint fk_OrderDetails_orderId foreign key (orderId) references dbo.Orders(orderId) on delete cascade,
	constraint fk_OrderDetails_gameId foreign key (gameId) references dbo.games(gameid),
);

create table dbo.Payment(
	paymentId int primary key identity(1,1),
	orderId int not null,
	payment_date datetime2 not null
		constraint df_payment_date default SYSUTCDATETIME(),
	payment_status varchar(50) not null
		constraint chk_payment_status check (payment_status in ('pending', 'completed', 'failed', 'refunded')),
	payment_method varchar(50) not null
		constraint chk_payment_method check (payment_method in ('credit_card', 'paypal', 'bank_transfer', 'gift_card')),
	transactionId varchar(100) null,
	amount decimal(10,2) not null
	    constraint chk_Payment_amount check (amount >= 0),
	constraint fk_paymentOrder_id foreign key (orderId) references dbo.Orders(orderId)
);

create table dbo.Cart(
	cartId int primary key identity(1,1),
	userId int not null, 
	gameId int not null,
	quantity int not null
		constraint chk_quantity check(quantity >= 0), 
	dateAdded datetime2 not null 
		constraint df_CartAdded default sysutcdatetime(),
	constraint fk_CartUser foreign key (userId) references dbo.Users(UserId),
	constraint fk_CartGame foreign key (gameId) references dbo.games(gameid)
);


-- Main person(admin) that need to be inserted for start of the game 
insert into Users (UserName, UserPassword, Email, UserRole, shippingAddress) values('admin', 'admin', 'admin1@gamestore.com', 'Admin', 'N/A');



--helpful indices that are used repeatidly 
create index idx_Orders_userId on dbo.Orders(userId);
create index idx_Orders_status on dbo.Orders(status);
create index idx_Payment_orderId on dbo.Payment(orderId);
create index idx_OrderDetails_orderId on dbo.OrderDetails(orderId);
create index idx_OrderDetails_gameId on dbo.OrderDetails(gameId);
create index idx_Inventory_gameId on dbo.Inventory(gameId);
create index idx_Cart_cartid on dbo.Cart(cartId);

-- View table 
CREATE VIEW view_gamedisplay AS
SELECT 
    g.gameid, 
    g.gametitle,
    (
        SELECT SUBSTRING(
            (
                SELECT ',' + gen.genrename AS [text()]
                FROM (
                    SELECT DISTINCT gen.genrename
                    FROM dbo.games_genre gg 
                    JOIN dbo.genre gen ON gg.genreid = gen.genreid
                    WHERE gg.gameid = g.gameid
                ) gen
                FOR XML PATH('')
            ), 2, 1000)
    ) AS genrename,
    (
        SELECT SUBSTRING(
            (
                SELECT ',' + plat.platformname AS [text()]
                FROM (
                    SELECT DISTINCT plat.platformname
                    FROM dbo.games_platform gp
                    JOIN dbo.platform plat ON gp.platformid = plat.platformid
                    WHERE gp.gameid = g.gameid
                ) plat
                FOR XML PATH('')
            ), 2, 1000)
    ) AS platformname,
    g.price, 
    ISNULL(inv.quantity, 0) AS quantity, 
    g.description 
FROM dbo.games g
LEFT JOIN dbo.Inventory inv ON g.gameid = inv.gameId
GROUP BY g.gameid, g.gametitle, g.price, g.description, inv.quantity;

--- Triggers to update inventory when item is added/deleted/updated in cart
CREATE TRIGGER trg_updateInventory
ON dbo.Cart
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE inv
    SET inv.quantity = inv.quantity - (i.quantity - d.quantity)
    FROM dbo.Inventory inv
    INNER JOIN inserted i ON inv.gameId = i.gameId
    INNER JOIN deleted d ON d.cartId = i.cartId
    WHERE i.quantity > d.quantity;
END;

CREATE TRIGGER trg_insertCart
ON dbo.Cart
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE inv
    SET inv.quantity = inv.quantity - i.quantity
    FROM dbo.Inventory inv
    INNER JOIN inserted i ON inv.gameId = i.gameId
    WHERE inv.quantity >= i.quantity;
END;

CREATE TRIGGER trg_deleteCart

ON dbo.Cart

AFTER DELETE

AS

BEGIN

    SET NOCOUNT ON;

    -- Check if the delete operation is triggered by an order placement

    DECLARE @isOrderPlacement BIT = 0;

    -- If the order exists in Orders, it means the deletion was triggered by placing an order.

    IF EXISTS (

        SELECT 1 

        FROM dbo.Orders o

        JOIN deleted d ON o.userId = d.userId

        WHERE o.orderDate >= DATEADD(SECOND, -5, SYSUTCDATETIME()) -- 5 seconds window

          AND o.status = 'pending'

    )

    BEGIN

        SET @isOrderPlacement = 1;

    END

    -- If it's not part of an order placement, restore inventory

    IF @isOrderPlacement = 0

    BEGIN

        UPDATE inv

        SET inv.quantity = inv.quantity + d.quantity

        FROM dbo.Inventory inv

        INNER JOIN deleted d ON inv.gameId = d.gameId;
    END
END;