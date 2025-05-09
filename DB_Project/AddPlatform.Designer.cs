namespace GameStore
{
    partial class AddPlatform
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
            this.label1 = new System.Windows.Forms.Label();
            this.add__button = new System.Windows.Forms.Button();
            this.name_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Platform";
            // 
            // add__button
            // 
            this.add__button.Location = new System.Drawing.Point(117, 67);
            this.add__button.Name = "add__button";
            this.add__button.Size = new System.Drawing.Size(75, 23);
            this.add__button.TabIndex = 4;
            this.add__button.Text = "Add";
            this.add__button.UseVisualStyleBackColor = true;
            this.add__button.Click += new System.EventHandler(this.add__button_Click);
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(94, 25);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(136, 20);
            this.name_text.TabIndex = 3;
            // 
            // AddPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(280, 128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add__button);
            this.Controls.Add(this.name_text);
            this.Name = "AddPlatform";
            this.Text = "Add Platform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add__button;
        private System.Windows.Forms.TextBox name_text;
    }
}