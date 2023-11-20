namespace break_isim_arama_2
{
    partial class Form1
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
            this.lstİsim = new System.Windows.Forms.ListBox();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstİsim
            // 
            this.lstİsim.BackColor = System.Drawing.Color.LavenderBlush;
            this.lstİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstİsim.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lstİsim.FormattingEnabled = true;
            this.lstİsim.ItemHeight = 16;
            this.lstİsim.Items.AddRange(new object[] {
            "Dilan",
            "Melek",
            "Helin",
            "Enes",
            "Ece",
            "Elif",
            "Kaan",
            "Sena",
            "Büşra",
            "Ceren",
            "Mustafa",
            "Ecrin",
            "Sena",
            "Burak",
            "Selin",
            "Mehmet",
            "Selma"});
            this.lstİsim.Location = new System.Drawing.Point(109, 21);
            this.lstİsim.Name = "lstİsim";
            this.lstİsim.Size = new System.Drawing.Size(155, 292);
            this.lstİsim.TabIndex = 5;
            // 
            // txtİsim
            // 
            this.txtİsim.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtİsim.Location = new System.Drawing.Point(8, 21);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(83, 20);
            this.txtİsim.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAra.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAra.Location = new System.Drawing.Point(8, 62);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(83, 31);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(302, 350);
            this.Controls.Add(this.lstİsim);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.btnAra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstİsim;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.Button btnAra;
    }
}

