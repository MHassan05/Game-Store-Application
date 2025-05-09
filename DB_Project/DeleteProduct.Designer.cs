namespace GameStore
{
    partial class DeleteProduct
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
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.confirmCB = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.gameid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gametitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_opt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameid,
            this.gametitle,
            this.price,
            this.delete_opt});
            this.productGridView.Location = new System.Drawing.Point(0, 0);
            this.productGridView.Name = "productGridView";
            this.productGridView.Size = new System.Drawing.Size(544, 290);
            this.productGridView.TabIndex = 0;
            // 
            // confirmCB
            // 
            this.confirmCB.AutoSize = true;
            this.confirmCB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmCB.Location = new System.Drawing.Point(234, 309);
            this.confirmCB.Name = "confirmCB";
            this.confirmCB.Size = new System.Drawing.Size(137, 24);
            this.confirmCB.TabIndex = 1;
            this.confirmCB.Text = "Are You Sure ?";
            this.confirmCB.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(377, 306);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(156, 28);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // gameid
            // 
            this.gameid.DataPropertyName = "gameid";
            this.gameid.HeaderText = "GameId";
            this.gameid.Name = "gameid";
            // 
            // gametitle
            // 
            this.gametitle.DataPropertyName = "gametitle";
            this.gametitle.HeaderText = "Title";
            this.gametitle.Name = "gametitle";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // delete_opt
            // 
            this.delete_opt.HeaderText = "Select To Delete";
            this.delete_opt.Name = "delete_opt";
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(545, 346);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.confirmCB);
            this.Controls.Add(this.productGridView);
            this.Name = "DeleteProduct";
            this.Text = "Delete Product";
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.CheckBox confirmCB;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gametitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delete_opt;
    }
}