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
            this.örnektimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BaslatTusu = new iTalk.iTalk_Button_1();
            this.İptalEtTusu = new iTalk.iTalk_Button_1();
            this.iTalk_Toggle1 = new iTalk.iTalk_Toggle();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14F);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bu islem programın tüm fonksiyonlarini yerine getirebilme özelligini kontrol eder" +
    "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 47);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(655, 24);
            this.progressBar1.TabIndex = 1;
            // 
            // KontrolTimer
            // 
            this.KontrolTimer.Tick += new System.EventHandler(this.KontrolTimer_Tick);
            // 
            // örnektimer
            // 
            this.örnektimer.Tick += new System.EventHandler(this.örnektimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.BaslatTusu);
            this.panel1.Controls.Add(this.İptalEtTusu);
            this.panel1.Controls.Add(this.iTalk_Toggle1);
            this.panel1.Location = new System.Drawing.Point(-10, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 68);
            this.panel1.TabIndex = 33444;
            // 
            // BaslatTusu
            // 
            this.BaslatTusu.BackColor = System.Drawing.Color.Transparent;
            this.BaslatTusu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.BaslatTusu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BaslatTusu.Image = null;
            this.BaslatTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BaslatTusu.Location = new System.Drawing.Point(509, 15);
            this.BaslatTusu.Name = "BaslatTusu";
            this.BaslatTusu.Size = new System.Drawing.Size(166, 40);
            this.BaslatTusu.TabIndex = 33452;
            this.BaslatTusu.Text = "Baslat";
            this.BaslatTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BaslatTusu.Click += new System.EventHandler(this.BaslatTusu_Click);
            // 
            // İptalEtTusu
            // 
            this.İptalEtTusu.BackColor = System.Drawing.Color.Transparent;
            this.İptalEtTusu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.İptalEtTusu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.İptalEtTusu.Image = null;
            this.İptalEtTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.İptalEtTusu.Location = new System.Drawing.Point(20, 15);
            this.İptalEtTusu.Name = "İptalEtTusu";
            this.İptalEtTusu.Size = new System.Drawing.Size(166, 40);
            this.İptalEtTusu.TabIndex = 33451;
            this.İptalEtTusu.Text = "İptal";
            this.İptalEtTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.İptalEtTusu.Click += new System.EventHandler(this.İptalEtTusu_Click);
            // 
            // iTalk_Toggle1
            // 
            this.iTalk_Toggle1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_Toggle1.Name = "iTalk_Toggle1";
            this.iTalk_Toggle1.Size = new System.Drawing.Size(0, 0);
            this.iTalk_Toggle1.TabIndex = 0;
            this.iTalk_Toggle1.Toggled = false;
            this.iTalk_Toggle1.Type = iTalk.iTalk_Toggle._Type.YesNo;
            // 
            // Kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(678, 159);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Kontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrol ";
            this.Load += new System.EventHandler(this.Kontrol_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer örnektimer;
        public System.Windows.Forms.Timer KontrolTimer;
        private System.Windows.Forms.Panel panel1;
        private iTalk.iTalk_Toggle iTalk_Toggle1;
        private iTalk.iTalk_Button_1 İptalEtTusu;
        private iTalk.iTalk_Button_1 BaslatTusu;
    }
}