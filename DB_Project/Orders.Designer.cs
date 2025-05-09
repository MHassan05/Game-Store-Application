namespace GameStore
{
    partial class Orders
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
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mkPayment = new System.Windows.Forms.Button();
            this.refundBtn = new System.Windows.Forms.Button();
            this.paymentMethod = new System.Windows.Forms.ComboBox();
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
            this.orderDate,
            this.amount,
            this.status,
            this.trackingNumber,
            this.select});
            this.order_grid.Location = new System.Drawing.Point(3, 1);
            this.order_grid.Name = "order_grid";
            this.order_grid.ReadOnly = true;
            this.order_grid.Size = new System.Drawing.Size(643, 322);
            this.order_grid.TabIndex = 0;
            this.order_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_grid_CellClick);
            this.order_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_grid_CellContentClick);
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "OrderId";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
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
            // mkPayment
            // 
            this.mkPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkPayment.Location = new System.Drawing.Point(512, 329);
            this.mkPayment.Name = "mkPayment";
            this.mkPayment.Size = new System.Drawing.Size(119, 23);
            this.mkPayment.TabIndex = 1;
            this.mkPayment.Text = "Make Payment";
            this.mkPayment.UseVisualStyleBackColor = true;
            this.mkPayment.Click += new System.EventHandler(this.mkPayment_Click);
            // 
            // refundBtn
            // 
            this.refundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundBtn.Location = new System.Drawing.Point(12, 329);
            this.refundBtn.Name = "refundBtn";
            this.refundBtn.Size = new System.Drawing.Size(156, 23);
            this.refundBtn.TabIndex = 2;
            this.refundBtn.Text = "Refund/Return/Cancel";
            this.refundBtn.UseVisualStyleBackColor = true;
            this.refundBtn.Click += new System.EventHandler(this.refundBtn_Click);
            // 
            // paymentMethod
            // 
            this.paymentMethod.FormattingEnabled = true;
            this.paymentMethod.Items.AddRange(new object[] {
            "credit_card",
            "paypal",
            "bank_transfer",
            "gift_card"});
            this.paymentMethod.Location = new System.Drawing.Point(385, 331);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(121, 21);
            this.paymentMethod.TabIndex = 3;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(637, 361);
            this.Controls.Add(this.paymentMethod);
            this.Controls.Add(this.refundBtn);
            this.Controls.Add(this.mkPayment);
            this.Controls.Add(this.order_grid);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.order_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView order_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.Button mkPayment;
        private System.Windows.Forms.Button refundBtn;
        private System.Windows.Forms.ComboBox paymentMethod;
    }
}