namespace GameStore
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcome_back_label = new System.Windows.Forms.Label();
            this.verticle_line_panel = new System.Windows.Forms.Panel();
            this.logout_user = new System.Windows.Forms.Button();
            this.product_grid = new System.Windows.Forms.DataGridView();
            this.gameid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.add_to_cart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.platform_cmbx = new System.Windows.Forms.ComboBox();
            this.genre_cmbx = new System.Windows.Forms.ComboBox();
            this.show_cart = new System.Windows.Forms.Button();
            this.show_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // welcome_back_label
            // 
            this.welcome_back_label.AutoSize = true;
            this.welcome_back_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_back_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcome_back_label.Location = new System.Drawing.Point(10, 66);
            this.welcome_back_label.Name = "welcome_back_label";
            this.welcome_back_label.Size = new System.Drawing.Size(110, 36);
            this.welcome_back_label.TabIndex = 3;
            this.welcome_back_label.Text = "Welcome Back\r\n      Hassan ";
            // 
            // verticle_line_panel
            // 
            this.verticle_line_panel.Location = new System.Drawing.Point(119, 1);
            this.verticle_line_panel.Name = "verticle_line_panel";
            this.verticle_line_panel.Size = new System.Drawing.Size(10, 448);
            this.verticle_line_panel.TabIndex = 4;
            // 
            // logout_user
            // 
            this.logout_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_user.Location = new System.Drawing.Point(22, 299);
            this.logout_user.Name = "logout_user";
            this.logout_user.Size = new System.Drawing.Size(75, 30);
            this.logout_user.TabIndex = 5;
            this.logout_user.Text = "Log Out";
            this.logout_user.UseVisualStyleBackColor = true;
            this.logout_user.Click += new System.EventHandler(this.logout_user_Click);
            // 
            // product_grid
            // 
            this.product_grid.AllowUserToAddRows = false;
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameid,
            this.gameName,
            this.genre,
            this.platform,
            this.price,
            this.quantity,
            this.Description,
            this.select});
            this.product_grid.Location = new System.Drawing.Point(122, 1);
            this.product_grid.Name = "product_grid";
            this.product_grid.Size = new System.Drawing.Size(848, 408);
            this.product_grid.TabIndex = 6;
            // 
            // gameid
            // 
            this.gameid.DataPropertyName = "gameid";
            this.gameid.HeaderText = "GameId";
            this.gameid.Name = "gameid";
            // 
            // gameName
            // 
            this.gameName.DataPropertyName = "gametitle";
            this.gameName.HeaderText = "GameName";
            this.gameName.Name = "gameName";
            // 
            // genre
            // 
            this.genre.DataPropertyName = "genrename";
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
            // platform
            // 
            this.platform.DataPropertyName = "platformname";
            this.platform.HeaderText = "Platform";
            this.platform.Name = "platform";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price($)";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // add_to_cart
            // 
            this.add_to_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_to_cart.Location = new System.Drawing.Point(822, 417);
            this.add_to_cart.Name = "add_to_cart";
            this.add_to_cart.Size = new System.Drawing.Size(136, 23);
            this.add_to_cart.TabIndex = 7;
            this.add_to_cart.Text = "Add Items to Cart";
            this.add_to_cart.UseVisualStyleBackColor = true;
            this.add_to_cart.Click += new System.EventHandler(this.add_to_cart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(135, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categorize by: ";
            // 
            // platform_cmbx
            // 
            this.platform_cmbx.FormattingEnabled = true;
            this.platform_cmbx.Location = new System.Drawing.Point(256, 417);
            this.platform_cmbx.Name = "platform_cmbx";
            this.platform_cmbx.Size = new System.Drawing.Size(121, 21);
            this.platform_cmbx.TabIndex = 10;
            this.platform_cmbx.SelectedIndexChanged += new System.EventHandler(this.platform_cmbx_SelectedIndexChanged);
            // 
            // genre_cmbx
            // 
            this.genre_cmbx.FormattingEnabled = true;
            this.genre_cmbx.Location = new System.Drawing.Point(384, 416);
            this.genre_cmbx.Name = "genre_cmbx";
            this.genre_cmbx.Size = new System.Drawing.Size(121, 21);
            this.genre_cmbx.TabIndex = 11;
            this.genre_cmbx.SelectedIndexChanged += new System.EventHandler(this.genre_cmbx_SelectedIndexChanged);
            // 
            // show_cart
            // 
            this.show_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_cart.Location = new System.Drawing.Point(22, 130);
            this.show_cart.Name = "show_cart";
            this.show_cart.Size = new System.Drawing.Size(75, 30);
            this.show_cart.TabIndex = 12;
            this.show_cart.Text = "CART";
            this.show_cart.UseVisualStyleBackColor = true;
            this.show_cart.Click += new System.EventHandler(this.show_cart_Click);
            // 
            // show_order
            // 
            this.show_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_order.Location = new System.Drawing.Point(22, 211);
            this.show_order.Name = "show_order";
            this.show_order.Size = new System.Drawing.Size(75, 30);
            this.show_order.TabIndex = 13;
            this.show_order.Text = "Orders";
            this.show_order.UseVisualStyleBackColor = true;
            this.show_order.Click += new System.EventHandler(this.show_order_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.show_order);
            this.Controls.Add(this.show_cart);
            this.Controls.Add(this.genre_cmbx);
            this.Controls.Add(this.platform_cmbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_to_cart);
            this.Controls.Add(this.product_grid);
            this.Controls.Add(this.logout_user);
            this.Controls.Add(this.verticle_line_panel);
            this.Controls.Add(this.welcome_back_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcome_back_label;
        private System.Windows.Forms.Panel verticle_line_panel;
        private System.Windows.Forms.Button logout_user;
        private System.Windows.Forms.DataGridView product_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.Button add_to_cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox platform_cmbx;
        private System.Windows.Forms.ComboBox genre_cmbx;
        private System.Windows.Forms.Button show_cart;
        private System.Windows.Forms.Button show_order;
    }
}