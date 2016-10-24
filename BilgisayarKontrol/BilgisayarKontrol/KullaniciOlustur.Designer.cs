namespace BilgisayarKontrol
{
    partial class KullaniciOlustur
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TamamTusu = new iTalk.iTalk_Button_1();
            this.KullaniciAdiTXT = new iTalk.iTalk_TextBox_Small();
            this.label4 = new System.Windows.Forms.Label();
            this.SifreTXT = new iTalk.iTalk_TextBox_Small();
            this.label1 = new System.Windows.Forms.Label();
            this.SifreTekrariTXT = new iTalk.iTalk_TextBox_Small();
            this.GizliCevapTXT = new iTalk.iTalk_TextBox_Small();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(13, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Unutulan sifreyi kurtarmak için";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.TamamTusu);
            this.panel4.Location = new System.Drawing.Point(-10, 355);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 63);
            this.panel4.TabIndex = 31;
            // 
            // TamamTusu
            // 
            this.TamamTusu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TamamTusu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TamamTusu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TamamTusu.Image = null;
            this.TamamTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TamamTusu.Location = new System.Drawing.Point(27, 10);
            this.TamamTusu.Name = "TamamTusu";
            this.TamamTusu.Size = new System.Drawing.Size(255, 40);
            this.TamamTusu.TabIndex = 33454;
            this.TamamTusu.Text = "Tamam";
            this.TamamTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TamamTusu.Click += new System.EventHandler(this.TamamTusu_Click);
            // 
            // KullaniciAdiTXT
            // 
            this.KullaniciAdiTXT.BackColor = System.Drawing.Color.Transparent;
            this.KullaniciAdiTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.KullaniciAdiTXT.ForeColor = System.Drawing.Color.DimGray;
            this.KullaniciAdiTXT.Location = new System.Drawing.Point(14, 44);
            this.KullaniciAdiTXT.MaxLength = 32767;
            this.KullaniciAdiTXT.Multiline = false;
            this.KullaniciAdiTXT.Name = "KullaniciAdiTXT";
            this.KullaniciAdiTXT.ReadOnly = false;
            this.KullaniciAdiTXT.Size = new System.Drawing.Size(258, 28);
            this.KullaniciAdiTXT.TabIndex = 33449;
            this.KullaniciAdiTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.KullaniciAdiTXT.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 32);
            this.label4.TabIndex = 33450;
            this.label4.Text = "Sifre";
            // 
            // SifreTXT
            // 
            this.SifreTXT.BackColor = System.Drawing.Color.Transparent;
            this.SifreTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.SifreTXT.ForeColor = System.Drawing.Color.DimGray;
            this.SifreTXT.Location = new System.Drawing.Point(16, 121);
            this.SifreTXT.MaxLength = 32767;
            this.SifreTXT.Multiline = false;
            this.SifreTXT.Name = "SifreTXT";
            this.SifreTXT.ReadOnly = false;
            this.SifreTXT.Size = new System.Drawing.Size(258, 28);
            this.SifreTXT.TabIndex = 33451;
            this.SifreTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.SifreTXT.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(8, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 33452;
            this.label1.Text = "Sifre Tekrari";
            // 
            // SifreTekrariTXT
            // 
            this.SifreTekrariTXT.BackColor = System.Drawing.Color.Transparent;
            this.SifreTekrariTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.SifreTekrariTXT.ForeColor = System.Drawing.Color.DimGray;
            this.SifreTekrariTXT.Location = new System.Drawing.Point(17, 204);
            this.SifreTekrariTXT.MaxLength = 32767;
            this.SifreTekrariTXT.Multiline = false;
            this.SifreTekrariTXT.Name = "SifreTekrariTXT";
            this.SifreTekrariTXT.ReadOnly = false;
            this.SifreTekrariTXT.Size = new System.Drawing.Size(258, 28);
            this.SifreTekrariTXT.TabIndex = 33453;
            this.SifreTekrariTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.SifreTekrariTXT.UseSystemPasswordChar = false;
            // 
            // GizliCevapTXT
            // 
            this.GizliCevapTXT.BackColor = System.Drawing.Color.Transparent;
            this.GizliCevapTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.GizliCevapTXT.ForeColor = System.Drawing.Color.DimGray;
            this.GizliCevapTXT.Location = new System.Drawing.Point(14, 285);
            this.GizliCevapTXT.MaxLength = 32767;
            this.GizliCevapTXT.Multiline = false;
            this.GizliCevapTXT.Name = "GizliCevapTXT";
            this.GizliCevapTXT.ReadOnly = false;
            this.GizliCevapTXT.Size = new System.Drawing.Size(258, 28);
            this.GizliCevapTXT.TabIndex = 33455;
            this.GizliCevapTXT.Text = "istanbul2016";
            this.GizliCevapTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.GizliCevapTXT.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(10, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 32);
            this.label5.TabIndex = 33454;
            this.label5.Text = "Gizli Cevap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 33447;
            this.label3.Text = "Kullanici Adi";
            // 
            // KullaniciOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(293, 418);
            this.Controls.Add(this.GizliCevapTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SifreTekrariTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KullaniciAdiTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "KullaniciOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FirstGiris_Load);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private iTalk.iTalk_TextBox_Small KullaniciAdiTXT;
        private System.Windows.Forms.Label label4;
        private iTalk.iTalk_TextBox_Small SifreTXT;
        private System.Windows.Forms.Label label1;
        private iTalk.iTalk_TextBox_Small SifreTekrariTXT;
        private iTalk.iTalk_Button_1 TamamTusu;
        private iTalk.iTalk_TextBox_Small GizliCevapTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}