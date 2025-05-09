namespace GameStore
{
    partial class CartedItem
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
            this.cart_grid = new System.Windows.Forms.DataGridView();
            this.remove_from_cart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gametitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateadded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cart_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // cart_grid
            // 
            this.cart_grid.AllowUserToAddRows = false;
            this.cart_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartId,
            this.gameId,
            this.gametitle,
            this.quantity,
            this.dateadded,
            this.select});
            this.cart_grid.Location = new System.Drawing.Point(-1, -1);
            this.cart_grid.Name = "cart_grid";
            this.cart_grid.Size = new System.Drawing.Size(648, 279);
            this.cart_grid.TabIndex = 0;
            // 
            // remove_from_cart
            // 
            this.remove_from_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_from_cart.Location = new System.Drawing.Point(431, 284);
            this.remove_from_cart.Name = "remove_from_cart";
            this.remove_from_cart.Size = new System.Drawing.Size(75, 23);
            this.remove_from_cart.TabIndex = 1;
            this.remove_from_cart.Text = "Remove Items";
            this.remove_from_cart.UseVisualStyleBackColor = true;
            this.remove_from_cart.Click += new System.EventHandler(this.remove_from_cart_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(522, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cartId
            // 
            this.cartId.DataPropertyName = "cartId";
            this.cartId.HeaderText = "Cart ID";
            this.cartId.Name = "cartId";
            // 
            // gameId
            // 
            this.gameId.DataPropertyName = "gameId";
            this.gameId.HeaderText = "Game ID";
            this.gameId.Name = "gameId";
            // 
            // gametitle
            // 
            this.gametitle.DataPropertyName = "gametitle";
            this.gametitle.HeaderText = "Name";
            this.gametitle.Name = "gametitle";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // dateadded
            // 
            this.dateadded.DataPropertyName = "dateAdded";
            this.dateadded.HeaderText = "Date Added";
            this.dateadded.Name = "dateadded";
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            // 
            // CartedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(642, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remove_from_cart);
            this.Controls.Add(this.cart_grid);
            this.Name = "CartedItem";
            this.Text = "Carted Item";
            ((System.ComponentModel.ISupportInitialize)(this.cart_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cart_grid;
        private System.Windows.Forms.Button remove_from_cart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gametitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateadded;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
    }
}