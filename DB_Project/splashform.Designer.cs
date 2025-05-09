namespace GameStore
{
    partial class splashform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.loading_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.rollbox = new System.Windows.Forms.ComboBox();
            this.login_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.login_hide_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progress_bar
            // 
            this.progress_bar.BackColor = System.Drawing.Color.White;
            this.progress_bar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progress_bar.ForeColor = System.Drawing.Color.Red;
            this.progress_bar.Location = new System.Drawing.Point(21, 320);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(166, 23);
            this.progress_bar.TabIndex = 1;
            // 
            // loading_label
            // 
            this.loading_label.AutoSize = true;
            this.loading_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_label.ForeColor = System.Drawing.Color.White;
            this.loading_label.Location = new System.Drawing.Point(20, 356);
            this.loading_label.Name = "loading_label";
            this.loading_label.Size = new System.Drawing.Size(167, 24);
            this.loading_label.TabIndex = 2;
            this.loading_label.Text = "Loading Data . . . ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(312, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(387, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login to you Account";
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.ForeColor = System.Drawing.Color.Black;
            this.username_textbox.Location = new System.Drawing.Point(391, 243);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(197, 29);
            this.username_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(255, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(255, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password ";
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.ForeColor = System.Drawing.Color.Black;
            this.password_textbox.Location = new System.Drawing.Point(391, 288);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(197, 29);
            this.password_textbox.TabIndex = 9;
            // 
            // rollbox
            // 
            this.rollbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rollbox.FormattingEnabled = true;
            this.rollbox.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.rollbox.Location = new System.Drawing.Point(467, 352);
            this.rollbox.Name = "rollbox";
            this.rollbox.Size = new System.Drawing.Size(121, 28);
            this.rollbox.TabIndex = 10;
            this.rollbox.Text = "Select Role";
            // 
            // login_button
            // 
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_button.Location = new System.Drawing.Point(625, 352);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(87, 32);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(625, 405);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(87, 33);
            this.signup_button.TabIndex = 12;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(405, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Don\'t have Account ? ";
            // 
            // login_hide_checkbox
            // 
            this.login_hide_checkbox.AutoSize = true;
            this.login_hide_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_hide_checkbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_hide_checkbox.Location = new System.Drawing.Point(594, 290);
            this.login_hide_checkbox.Name = "login_hide_checkbox";
            this.login_hide_checkbox.Size = new System.Drawing.Size(69, 28);
            this.login_hide_checkbox.TabIndex = 14;
            this.login_hide_checkbox.Text = "Hide";
            this.login_hide_checkbox.UseVisualStyleBackColor = true;
            this.login_hide_checkbox.CheckedChanged += new System.EventHandler(this.login_hide_checkbox_CheckedChanged);
            // 
            // splashform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_hide_checkbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.rollbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.loading_label);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "splashform";
            this.Text = "Welcome Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.Label loading_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.ComboBox rollbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox login_hide_checkbox;
    }
}

