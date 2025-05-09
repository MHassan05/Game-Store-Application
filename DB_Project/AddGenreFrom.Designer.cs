namespace GameStore
{
    partial class AddGenreFrom
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
            this.add_genere_text = new System.Windows.Forms.TextBox();
            this.add_genere_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_genere_text
            // 
            this.add_genere_text.Location = new System.Drawing.Point(115, 12);
            this.add_genere_text.Name = "add_genere_text";
            this.add_genere_text.Size = new System.Drawing.Size(136, 20);
            this.add_genere_text.TabIndex = 0;
         
            // 
            // add_genere_button
            // 
            this.add_genere_button.Location = new System.Drawing.Point(135, 57);
            this.add_genere_button.Name = "add_genere_button";
            this.add_genere_button.Size = new System.Drawing.Size(75, 23);
            this.add_genere_button.TabIndex = 1;
            this.add_genere_button.Text = "Add";
            this.add_genere_button.UseVisualStyleBackColor = true;
            this.add_genere_button.Click += new System.EventHandler(this.add_genere_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genre Name";
            // 
            // AddGenreFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(282, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_genere_button);
            this.Controls.Add(this.add_genere_text);
            this.Name = "AddGenreFrom";
            this.Text = "Add Genre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_genere_text;
        private System.Windows.Forms.Button add_genere_button;
        private System.Windows.Forms.Label label1;
    }
}