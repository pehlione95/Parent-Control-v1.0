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
            this.güvenlikcevabiTXT = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kapattusu = new System.Windows.Forms.PictureBox();
            this.tamam = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapattusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // güvenlikcevabiTXT
            // 
            this.güvenlikcevabiTXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güvenlikcevabiTXT.Location = new System.Drawing.Point(12, 64);
            this.güvenlikcevabiTXT.Name = "güvenlikcevabiTXT";
            this.güvenlikcevabiTXT.Size = new System.Drawing.Size(260, 27);
            this.güvenlikcevabiTXT.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.kapattusu);
            this.panel4.Controls.Add(this.tamam);
            this.panel4.Location = new System.Drawing.Point(-30, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 63);
            this.panel4.TabIndex = 26;
            // 
            // kapattusu
            // 
            this.kapattusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4rwvAD;
            this.kapattusu.Location = new System.Drawing.Point(42, 8);
            this.kapattusu.Name = "kapattusu";
            this.kapattusu.Size = new System.Drawing.Size(50, 48);
            this.kapattusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kapattusu.TabIndex = 30;
            this.kapattusu.TabStop = false;
            this.kapattusu.Click += new System.EventHandler(this.kapattusu_Click);
            // 
            // tamam
            // 
            this.tamam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tamam.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6mkMqS;
            this.tamam.Location = new System.Drawing.Point(254, 8);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(50, 49);
            this.tamam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tamam.TabIndex = 27;
            this.tamam.TabStop = false;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_05T5jU;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(294, 192);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.güvenlikcevabiTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifremi Unuttum";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapattusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox güvenlikcevabiTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox tamam;
        private System.Windows.Forms.PictureBox kapattusu;
    }
}