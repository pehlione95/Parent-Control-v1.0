namespace BilgisayarKontrol
{
    partial class Login
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
            this.KullaniciAdiTXT = new iTalk.iTalk_TextBox_Big();
            this.sifreTXT = new iTalk.iTalk_TextBox_Big();
            this.GirisTusu = new iTalk.iTalk_Button_2();
            this.SuspendLayout();
            // 
            // KullaniciAdiTXT
            // 
            this.KullaniciAdiTXT.BackColor = System.Drawing.Color.Transparent;
            this.KullaniciAdiTXT.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F);
            this.KullaniciAdiTXT.ForeColor = System.Drawing.Color.DimGray;
            this.KullaniciAdiTXT.Image = null;
            this.KullaniciAdiTXT.Location = new System.Drawing.Point(126, 177);
            this.KullaniciAdiTXT.MaxLength = 32767;
            this.KullaniciAdiTXT.Multiline = false;
            this.KullaniciAdiTXT.Name = "KullaniciAdiTXT";
            this.KullaniciAdiTXT.ReadOnly = false;
            this.KullaniciAdiTXT.Size = new System.Drawing.Size(294, 43);
            this.KullaniciAdiTXT.TabIndex = 33449;
            this.KullaniciAdiTXT.Text = "samet";
            this.KullaniciAdiTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.KullaniciAdiTXT.UseSystemPasswordChar = false;
            // 
            // sifreTXT
            // 
            this.sifreTXT.BackColor = System.Drawing.Color.Transparent;
            this.sifreTXT.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F);
            this.sifreTXT.ForeColor = System.Drawing.Color.DimGray;
            this.sifreTXT.Image = null;
            this.sifreTXT.Location = new System.Drawing.Point(126, 224);
            this.sifreTXT.MaxLength = 32767;
            this.sifreTXT.Multiline = false;
            this.sifreTXT.Name = "sifreTXT";
            this.sifreTXT.ReadOnly = false;
            this.sifreTXT.Size = new System.Drawing.Size(294, 43);
            this.sifreTXT.TabIndex = 33448;
            this.sifreTXT.Text = "1244";
            this.sifreTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.sifreTXT.UseSystemPasswordChar = true;
            // 
            // GirisTusu
            // 
            this.GirisTusu.BackColor = System.Drawing.Color.Transparent;
            this.GirisTusu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.GirisTusu.ForeColor = System.Drawing.Color.White;
            this.GirisTusu.Image = global::BilgisayarKontrol.Properties.Resources.Forward_30;
            this.GirisTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GirisTusu.Location = new System.Drawing.Point(426, 177);
            this.GirisTusu.Name = "GirisTusu";
            this.GirisTusu.Size = new System.Drawing.Size(56, 88);
            this.GirisTusu.TabIndex = 33447;
            this.GirisTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GirisTusu.Click += new System.EventHandler(this.GirisTusu_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 376);
            this.Controls.Add(this.KullaniciAdiTXT);
            this.Controls.Add(this.sifreTXT);
            this.Controls.Add(this.GirisTusu);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_TextBox_Big KullaniciAdiTXT;
        private iTalk.iTalk_TextBox_Big sifreTXT;
        private iTalk.iTalk_Button_2 GirisTusu;
    }
}