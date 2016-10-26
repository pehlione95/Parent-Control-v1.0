namespace BilgisayarKontrol
{
    partial class SifremiUnuttum
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.TamamTusu = new iTalk.iTalk_Button_1();
            this.label2 = new System.Windows.Forms.Label();
            this.güvenlikcevabiTXT = new iTalk.iTalk_TextBox_Small();
            this.label1 = new System.Windows.Forms.Label();
            this.kadiTXT = new iTalk.iTalk_TextBox_Small();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.TamamTusu);
            this.panel4.Location = new System.Drawing.Point(-20, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 63);
            this.panel4.TabIndex = 26;
            // 
            // TamamTusu
            // 
            this.TamamTusu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TamamTusu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TamamTusu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TamamTusu.Image = null;
            this.TamamTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TamamTusu.Location = new System.Drawing.Point(42, 12);
            this.TamamTusu.Name = "TamamTusu";
            this.TamamTusu.Size = new System.Drawing.Size(295, 40);
            this.TamamTusu.TabIndex = 33455;
            this.TamamTusu.Text = "Tamam";
            this.TamamTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TamamTusu.Click += new System.EventHandler(this.TamamTusu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 64);
            this.label2.TabIndex = 33446;
            this.label2.Text = "Sifrenizi olustururken\r\nbelirlediginiz kelimeyi yaziniz";
            // 
            // güvenlikcevabiTXT
            // 
            this.güvenlikcevabiTXT.BackColor = System.Drawing.Color.Transparent;
            this.güvenlikcevabiTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.güvenlikcevabiTXT.ForeColor = System.Drawing.Color.DimGray;
            this.güvenlikcevabiTXT.Location = new System.Drawing.Point(22, 175);
            this.güvenlikcevabiTXT.MaxLength = 32767;
            this.güvenlikcevabiTXT.Multiline = false;
            this.güvenlikcevabiTXT.Name = "güvenlikcevabiTXT";
            this.güvenlikcevabiTXT.ReadOnly = false;
            this.güvenlikcevabiTXT.Size = new System.Drawing.Size(295, 28);
            this.güvenlikcevabiTXT.TabIndex = 33447;
            this.güvenlikcevabiTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.güvenlikcevabiTXT.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 33448;
            this.label1.Text = "Kullanici adiniz";
            // 
            // kadiTXT
            // 
            this.kadiTXT.BackColor = System.Drawing.Color.Transparent;
            this.kadiTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.kadiTXT.ForeColor = System.Drawing.Color.DimGray;
            this.kadiTXT.Location = new System.Drawing.Point(22, 48);
            this.kadiTXT.MaxLength = 32767;
            this.kadiTXT.Multiline = false;
            this.kadiTXT.Name = "kadiTXT";
            this.kadiTXT.ReadOnly = false;
            this.kadiTXT.Size = new System.Drawing.Size(295, 28);
            this.kadiTXT.TabIndex = 33449;
            this.kadiTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.kadiTXT.UseSystemPasswordChar = false;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(341, 289);
            this.Controls.Add(this.kadiTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.güvenlikcevabiTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifremi Unuttum";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private iTalk.iTalk_Button_1 TamamTusu;
        private iTalk.iTalk_TextBox_Small güvenlikcevabiTXT;
        private System.Windows.Forms.Label label1;
        private iTalk.iTalk_TextBox_Small kadiTXT;
    }
}