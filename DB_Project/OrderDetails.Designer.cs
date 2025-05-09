namespace GameStore
{
    partial class OrderDetails
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
            this.orderDetail_grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetail_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetail_grid
            // 
            this.orderDetail_grid.AllowUserToAddRows = false;
            this.orderDetail_grid.AllowUserToDeleteRows = false;
            this.orderDetail_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetail_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.orderId,
            this.gameId,
            this.gameTitle,
            this.quantity,
            this.price});
            this.orderDetail_grid.Location = new System.Drawing.Point(0, 0);
            this.orderDetail_grid.Name = "orderDetail_grid";
            this.orderDetail_grid.ReadOnly = true;
            this.orderDetail_grid.Size = new System.Drawing.Size(643, 297);
            this.orderDetail_grid.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "orderDetailId";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "Order ID";
            this.orderId.Name = "orderId";
            // 
            // gameId
            // 
            this.gameId.DataPropertyName = "gameId";
            this.gameId.HeaderText = "Game ID";
            this.gameId.Name = "gameId";
            // 
            // gameTitle
            // 
            this.gameTitle.DataPropertyName = "gametitle";
            this.gameTitle.HeaderText = "Game Name";
            this.gameTitle.Name = "gameTitle";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.DataPropertyName = "pricePerUnit";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(645, 300);
            this.Controls.Add(this.orderDetail_grid);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.orderDetail_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderDetail_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}