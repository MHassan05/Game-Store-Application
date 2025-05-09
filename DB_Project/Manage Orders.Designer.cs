namespace GameStore
{
    partial class Manage_Orders
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
            this.order_grid = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cancel_button = new System.Windows.Forms.Button();
            this.userCMB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.order_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // order_grid
            // 
            this.order_grid.AllowUserToAddRows = false;
            this.order_grid.AllowUserToDeleteRows = false;
            this.order_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.userId,
            this.orderDate,
            this.amount,
            this.status,
            this.trackingNumber,
            this.select});
            this.order_grid.Location = new System.Drawing.Point(1, 1);
            this.order_grid.Name = "order_grid";
            this.order_grid.ReadOnly = true;
            this.order_grid.Size = new System.Drawing.Size(747, 322);
            this.order_grid.TabIndex = 1;
            this.order_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_grid_CellClick);
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "OrderId";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "UserId";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.DataPropertyName = "orderDate";
            this.orderDate.HeaderText = "Ordered Date";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "totalAmount";
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // trackingNumber
            // 
            this.trackingNumber.DataPropertyName = "trackingNumber";
            this.trackingNumber.HeaderText = "Tracking Number";
            this.trackingNumber.Name = "trackingNumber";
            this.trackingNumber.ReadOnly = true;
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(622, 332);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(115, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel Order(s)";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // userCMB
            // 
            this.userCMB.FormattingEnabled = true;
            this.userCMB.Location = new System.Drawing.Point(156, 334);
            this.userCMB.Name = "userCMB";
            this.userCMB.Size = new System.Drawing.Size(121, 21);
            this.userCMB.TabIndex = 3;
            this.userCMB.SelectedIndexChanged += new System.EventHandler(this.userCMB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categorize By User";
            // 
            // Manage_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(749, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userCMB);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.order_grid);
            this.Name = "Manage_Orders";
            this.Text = "Manage Orders";
            ((System.ComponentModel.ISupportInitialize)(this.order_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView order_grid;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.ComboBox userCMB;
        private System.Windows.Forms.Label label1;
    }
}