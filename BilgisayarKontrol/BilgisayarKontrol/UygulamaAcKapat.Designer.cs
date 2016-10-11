namespace BilgisayarKontrol
{
    partial class UygulamaAcKapat
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
            this.iptalettusu = new System.Windows.Forms.PictureBox();
            this.tamam = new System.Windows.Forms.PictureBox();
            this.uygulamadiTXT = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kapatradio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openradio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dosyasec = new System.Windows.Forms.PictureBox();
            this.bilgilendirme = new System.Windows.Forms.Label();
            this.DevamEdenlerTsu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptalettusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamam)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dosyasec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.iptalettusu);
            this.panel4.Controls.Add(this.tamam);
            this.panel4.Location = new System.Drawing.Point(-2, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 63);
            this.panel4.TabIndex = 33;
            // 
            // iptalettusu
            // 
            this.iptalettusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iptalettusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4rwvAD;
            this.iptalettusu.Location = new System.Drawing.Point(11, 6);
            this.iptalettusu.Name = "iptalettusu";
            this.iptalettusu.Size = new System.Drawing.Size(50, 48);
            this.iptalettusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iptalettusu.TabIndex = 29;
            this.iptalettusu.TabStop = false;
            this.iptalettusu.Click += new System.EventHandler(this.iptalettusu_Click);
            // 
            // tamam
            // 
            this.tamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamam.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6mkMqS;
            this.tamam.Location = new System.Drawing.Point(393, 6);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(50, 49);
            this.tamam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tamam.TabIndex = 30;
            this.tamam.TabStop = false;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // uygulamadiTXT
            // 
            this.uygulamadiTXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uygulamadiTXT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.uygulamadiTXT.Location = new System.Drawing.Point(12, 43);
            this.uygulamadiTXT.Name = "uygulamadiTXT";
            this.uygulamadiTXT.ReadOnly = true;
            this.uygulamadiTXT.Size = new System.Drawing.Size(377, 27);
            this.uygulamadiTXT.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 27);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // kapatradio
            // 
            this.kapatradio.AutoSize = true;
            this.kapatradio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapatradio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.kapatradio.Location = new System.Drawing.Point(34, 10);
            this.kapatradio.Name = "kapatradio";
            this.kapatradio.Size = new System.Drawing.Size(66, 23);
            this.kapatradio.TabIndex = 36;
            this.kapatradio.TabStop = true;
            this.kapatradio.Text = "Kapat";
            this.kapatradio.UseVisualStyleBackColor = true;
            this.kapatradio.CheckedChanged += new System.EventHandler(this.kapatradio_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.kapatradio);
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 46);
            this.panel1.TabIndex = 41;
            // 
            // openradio
            // 
            this.openradio.AutoSize = true;
            this.openradio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.openradio.Checked = true;
            this.openradio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openradio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.openradio.Location = new System.Drawing.Point(33, 11);
            this.openradio.Name = "openradio";
            this.openradio.Size = new System.Drawing.Size(45, 23);
            this.openradio.TabIndex = 37;
            this.openradio.TabStop = true;
            this.openradio.Text = "Aç";
            this.openradio.UseVisualStyleBackColor = false;
            this.openradio.CheckedChanged += new System.EventHandler(this.openradio_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.openradio);
            this.panel2.Location = new System.Drawing.Point(0, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 46);
            this.panel2.TabIndex = 42;
            // 
            // dosyasec
            // 
            this.dosyasec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dosyasec.Location = new System.Drawing.Point(395, 43);
            this.dosyasec.Name = "dosyasec";
            this.dosyasec.Size = new System.Drawing.Size(46, 43);
            this.dosyasec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dosyasec.TabIndex = 37;
            this.dosyasec.TabStop = false;
            this.dosyasec.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bilgilendirme
            // 
            this.bilgilendirme.AutoSize = true;
            this.bilgilendirme.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgilendirme.ForeColor = System.Drawing.SystemColors.Control;
            this.bilgilendirme.Location = new System.Drawing.Point(8, 281);
            this.bilgilendirme.Name = "bilgilendirme";
            this.bilgilendirme.Size = new System.Drawing.Size(224, 19);
            this.bilgilendirme.TabIndex = 43;
            this.bilgilendirme.Text = "* Sadece 1 işlem yapabilirsiniz";
            // 
            // DevamEdenlerTsu
            // 
            this.DevamEdenlerTsu.AutoSize = true;
            this.DevamEdenlerTsu.Font = new System.Drawing.Font("Yu Gothic UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DevamEdenlerTsu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DevamEdenlerTsu.Location = new System.Drawing.Point(6, 8);
            this.DevamEdenlerTsu.Name = "DevamEdenlerTsu";
            this.DevamEdenlerTsu.Size = new System.Drawing.Size(157, 32);
            this.DevamEdenlerTsu.TabIndex = 44;
            this.DevamEdenlerTsu.Text = "Uygulama Adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(5, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 45;
            this.label1.Text = "İslem zamani";
            // 
            // UygulamaAcKapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(453, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DevamEdenlerTsu);
            this.Controls.Add(this.bilgilendirme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dosyasec);
            this.Controls.Add(this.uygulamadiTXT);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "UygulamaAcKapat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulama Aç \\ Kapat";
            this.Load += new System.EventHandler(this.UygulamaAcKapat_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptalettusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dosyasec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox iptalettusu;
        private System.Windows.Forms.PictureBox tamam;
        public System.Windows.Forms.TextBox uygulamadiTXT;
        private System.Windows.Forms.PictureBox dosyasec;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton kapatradio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton openradio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label bilgilendirme;
        private System.Windows.Forms.Label DevamEdenlerTsu;
        private System.Windows.Forms.Label label1;
    }
}