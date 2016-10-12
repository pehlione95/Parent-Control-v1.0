namespace BilgisayarKontrol
{
    partial class Kontrol
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.KontrolTimer = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.örnektimer = new System.Windows.Forms.Timer(this.components);
            this.gif = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.İptalEtTusu = new System.Windows.Forms.PictureBox();
            this.BaslatTusu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.İptalEtTusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaslatTusu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bu islem programın tüm fonksiyonlarını yerine getirebilme özelliğini kontrol eder" +
    "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 47);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(670, 39);
            this.progressBar1.TabIndex = 1;
            // 
            // KontrolTimer
            // 
            this.KontrolTimer.Tick += new System.EventHandler(this.KontrolTimer_Tick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(10, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 4);
            this.panel4.TabIndex = 4;
            // 
            // örnektimer
            // 
            this.örnektimer.Tick += new System.EventHandler(this.örnektimer_Tick);
            // 
            // gif
            // 
            this.gif.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gif.Image = global::BilgisayarKontrol.Properties.Resources.Yükleniyor;
            this.gif.Location = new System.Drawing.Point(78, 6);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(49, 48);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif.TabIndex = 23;
            this.gif.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.İptalEtTusu);
            this.panel1.Controls.Add(this.gif);
            this.panel1.Controls.Add(this.BaslatTusu);
            this.panel1.Location = new System.Drawing.Point(-10, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 63);
            this.panel1.TabIndex = 33444;
            // 
            // İptalEtTusu
            // 
            this.İptalEtTusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.İptalEtTusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4rwvAD;
            this.İptalEtTusu.Location = new System.Drawing.Point(22, 6);
            this.İptalEtTusu.Name = "İptalEtTusu";
            this.İptalEtTusu.Size = new System.Drawing.Size(50, 48);
            this.İptalEtTusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.İptalEtTusu.TabIndex = 29;
            this.İptalEtTusu.TabStop = false;
            this.İptalEtTusu.Click += new System.EventHandler(this.İptalEtTusu_Click);
            // 
            // BaslatTusu
            // 
            this.BaslatTusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaslatTusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6mkMqS;
            this.BaslatTusu.Location = new System.Drawing.Point(640, 6);
            this.BaslatTusu.Name = "BaslatTusu";
            this.BaslatTusu.Size = new System.Drawing.Size(50, 49);
            this.BaslatTusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BaslatTusu.TabIndex = 30;
            this.BaslatTusu.TabStop = false;
            this.BaslatTusu.Click += new System.EventHandler(this.BaslatTusu_Click);
            // 
            // Kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(689, 185);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Kontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrol ";
            this.Load += new System.EventHandler(this.Kontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.İptalEtTusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaslatTusu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer örnektimer;
        private System.Windows.Forms.PictureBox gif;
        public System.Windows.Forms.Timer KontrolTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox İptalEtTusu;
        private System.Windows.Forms.PictureBox BaslatTusu;
    }
}