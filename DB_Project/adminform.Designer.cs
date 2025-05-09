namespace GameStore
{
    partial class adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminform));
            this.add_admin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcome_back_label = new System.Windows.Forms.Label();
            this.line_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.mng_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_admin
            // 
            this.add_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_admin.Location = new System.Drawing.Point(21, 253);
            this.add_admin.Name = "add_admin";
            this.add_admin.Size = new System.Drawing.Size(110, 47);
            this.add_admin.TabIndex = 0;
            this.add_admin.Text = "Add New Admin";
            this.add_admin.UseVisualStyleBackColor = true;
            this.add_admin.Click += new System.EventHandler(this.add_admin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // welcome_back_label
            // 
            this.welcome_back_label.AutoSize = true;
            this.welcome_back_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_back_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcome_back_label.Location = new System.Drawing.Point(196, 131);
            this.welcome_back_label.Name = "welcome_back_label";
            this.welcome_back_label.Size = new System.Drawing.Size(110, 36);
            this.welcome_back_label.TabIndex = 2;
            this.welcome_back_label.Text = "Welcome Back\r\n      Hassan ";
            // 
            // line_panel
            // 
            this.line_panel.BackColor = System.Drawing.Color.White;
            this.line_panel.Location = new System.Drawing.Point(2, 190);
            this.line_panel.Name = "line_panel";
            this.line_panel.Size = new System.Drawing.Size(527, 11);
            this.line_panel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert New Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(363, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete A Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(191, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 47);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add New Genre";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(191, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 47);
            this.button5.TabIndex = 9;
            this.button5.Text = "Add New Platform";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // mng_order
            // 
            this.mng_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mng_order.Location = new System.Drawing.Point(363, 349);
            this.mng_order.Name = "mng_order";
            this.mng_order.Size = new System.Drawing.Size(110, 47);
            this.mng_order.TabIndex = 10;
            this.mng_order.Text = "Manage Orders";
            this.mng_order.UseVisualStyleBackColor = true;
            this.mng_order.Click += new System.EventHandler(this.mng_order_Click);
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.mng_order);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.line_panel);
            this.Controls.Add(this.welcome_back_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add_admin);
            this.Name = "adminform";
            this.Text = "Admin form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_admin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcome_back_label;
        private System.Windows.Forms.Panel line_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button mng_order;
    }
}