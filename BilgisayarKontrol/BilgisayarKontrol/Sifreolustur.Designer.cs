namespace BilgisayarKontrol
{
    partial class Sifreolustur
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
            this.sifreTXT = new System.Windows.Forms.TextBox();
            this.cevapTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kapattusu = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sifreolusturtusu = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kapattusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreolusturtusu)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sifreTXT
            // 
            this.sifreTXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTXT.Location = new System.Drawing.Point(12, 62);
            this.sifreTXT.Name = "sifreTXT";
            this.sifreTXT.Size = new System.Drawing.Size(258, 27);
            this.sifreTXT.TabIndex = 22;
            // 
            // cevapTXT
            // 
            this.cevapTXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapTXT.Location = new System.Drawing.Point(12, 165);
            this.cevapTXT.Name = "cevapTXT";
            this.cevapTXT.Size = new System.Drawing.Size(258, 27);
            this.cevapTXT.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "En az 4 rakam.1234 örnek olabilir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Unutulan sifreyi kurtarmak için";
            // 
            // kapattusu
            // 
            this.kapattusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4rwvAD;
            this.kapattusu.Location = new System.Drawing.Point(53, 7);
            this.kapattusu.Name = "kapattusu";
            this.kapattusu.Size = new System.Drawing.Size(50, 48);
            this.kapattusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kapattusu.TabIndex = 29;
            this.kapattusu.TabStop = false;
            this.kapattusu.Click += new System.EventHandler(this.kapattusu_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_3VM2Ks;
            this.pictureBox3.Location = new System.Drawing.Point(12, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_7wWYKs;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // sifreolusturtusu
            // 
            this.sifreolusturtusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6mkMqS;
            this.sifreolusturtusu.Location = new System.Drawing.Point(270, 6);
            this.sifreolusturtusu.Name = "sifreolusturtusu";
            this.sifreolusturtusu.Size = new System.Drawing.Size(50, 49);
            this.sifreolusturtusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sifreolusturtusu.TabIndex = 30;
            this.sifreolusturtusu.TabStop = false;
            this.sifreolusturtusu.Click += new System.EventHandler(this.sifreolusturtusu_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.kapattusu);
            this.panel4.Controls.Add(this.sifreolusturtusu);
            this.panel4.Location = new System.Drawing.Point(-37, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 63);
            this.panel4.TabIndex = 31;
            // 
            // Sifreolustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(290, 387);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cevapTXT);
            this.Controls.Add(this.sifreTXT);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Sifreolustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Yönetici Sifrenizi Olusturun";
            this.Load += new System.EventHandler(this.FirstGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kapattusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreolusturtusu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sifreTXT;
        private System.Windows.Forms.TextBox cevapTXT;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox kapattusu;
        private System.Windows.Forms.PictureBox sifreolusturtusu;
        private System.Windows.Forms.Panel panel4;
    }
}