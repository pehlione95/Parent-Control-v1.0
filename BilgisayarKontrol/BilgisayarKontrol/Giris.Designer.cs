namespace BilgisayarKontrol
{
    partial class Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.KullaniciAdiTXT = new iTalk.iTalk_TextBox_Big();
            this.sifreTXT = new iTalk.iTalk_TextBox_Big();
            this.GirisTusu = new iTalk.iTalk_Button_2();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(78, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 33440;
            this.label2.Text = "Sifremi unuttum";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(78, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 33439;
            this.label1.Text = "Kullanıcı sifreniz ile giris yapınız";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6yirxO;
            this.pictureBox1.Location = new System.Drawing.Point(52, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 114);
            this.pictureBox1.TabIndex = 33438;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(-19, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 2);
            this.panel4.TabIndex = 33441;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_1RBsZw;
            this.pictureBox6.Location = new System.Drawing.Point(432, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 58);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 33445;
            this.pictureBox6.TabStop = false;
            // 
            // KullaniciAdiTXT
            // 
            this.KullaniciAdiTXT.BackColor = System.Drawing.Color.Transparent;
            this.KullaniciAdiTXT.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F);
            this.KullaniciAdiTXT.ForeColor = System.Drawing.Color.DimGray;
            this.KullaniciAdiTXT.Image = null;
            this.KullaniciAdiTXT.Location = new System.Drawing.Point(82, 177);
            this.KullaniciAdiTXT.MaxLength = 32767;
            this.KullaniciAdiTXT.Multiline = false;
            this.KullaniciAdiTXT.Name = "KullaniciAdiTXT";
            this.KullaniciAdiTXT.ReadOnly = false;
            this.KullaniciAdiTXT.Size = new System.Drawing.Size(294, 43);
            this.KullaniciAdiTXT.TabIndex = 33446;
            this.KullaniciAdiTXT.Text = "samet";
            this.KullaniciAdiTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.KullaniciAdiTXT.UseSystemPasswordChar = false;
            this.KullaniciAdiTXT.TextChanged += new System.EventHandler(this.KullaniciAdiTXT_TextChanged);
            // 
            // sifreTXT
            // 
            this.sifreTXT.BackColor = System.Drawing.Color.Transparent;
            this.sifreTXT.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F);
            this.sifreTXT.ForeColor = System.Drawing.Color.DimGray;
            this.sifreTXT.Image = null;
            this.sifreTXT.Location = new System.Drawing.Point(82, 224);
            this.sifreTXT.MaxLength = 32767;
            this.sifreTXT.Multiline = false;
            this.sifreTXT.Name = "sifreTXT";
            this.sifreTXT.ReadOnly = false;
            this.sifreTXT.Size = new System.Drawing.Size(294, 43);
            this.sifreTXT.TabIndex = 33444;
            this.sifreTXT.Text = "1234";
            this.sifreTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.sifreTXT.UseSystemPasswordChar = true;
            this.sifreTXT.TextChanged += new System.EventHandler(this.KullaniciAdiTXT_TextChanged);
            // 
            // GirisTusu
            // 
            this.GirisTusu.BackColor = System.Drawing.Color.Transparent;
            this.GirisTusu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.GirisTusu.ForeColor = System.Drawing.Color.White;
            this.GirisTusu.Image = global::BilgisayarKontrol.Properties.Resources.Forward_30;
            this.GirisTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GirisTusu.Location = new System.Drawing.Point(382, 177);
            this.GirisTusu.Name = "GirisTusu";
            this.GirisTusu.Size = new System.Drawing.Size(56, 88);
            this.GirisTusu.TabIndex = 33442;
            this.GirisTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GirisTusu.Click += new System.EventHandler(this.GirisTusu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Help;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F);
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(78, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 33447;
            this.label3.Text = "Sifre degistir";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(508, 344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KullaniciAdiTXT);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.sifreTXT);
            this.Controls.Add(this.GirisTusu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private iTalk.iTalk_Button_2 GirisTusu;
        private iTalk.iTalk_TextBox_Big sifreTXT;
        private System.Windows.Forms.PictureBox pictureBox6;
        private iTalk.iTalk_TextBox_Big KullaniciAdiTXT;
        private System.Windows.Forms.Label label3;
    }
}