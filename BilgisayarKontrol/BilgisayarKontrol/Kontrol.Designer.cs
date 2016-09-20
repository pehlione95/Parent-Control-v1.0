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
            this.tamamtusu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.örnektimer = new System.Windows.Forms.Timer(this.components);
            this.gif = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bu islem programın tüm fonksiyonlarını yerine getirebilme özelliğini kontrol eder" +
    "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 47);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(578, 39);
            this.progressBar1.TabIndex = 1;
            // 
            // KontrolTimer
            // 
            this.KontrolTimer.Tick += new System.EventHandler(this.KontrolTimer_Tick);
            // 
            // tamamtusu
            // 
            this.tamamtusu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tamamtusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamamtusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tamamtusu.Location = new System.Drawing.Point(386, 122);
            this.tamamtusu.Name = "tamamtusu";
            this.tamamtusu.Size = new System.Drawing.Size(202, 48);
            this.tamamtusu.TabIndex = 13;
            this.tamamtusu.Text = "Kapat";
            this.tamamtusu.UseVisualStyleBackColor = false;
            this.tamamtusu.Click += new System.EventHandler(this.tamamtusu_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(10, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 2);
            this.panel4.TabIndex = 2;
            // 
            // örnektimer
            // 
            this.örnektimer.Tick += new System.EventHandler(this.örnektimer_Tick);
            // 
            // gif
            // 
            this.gif.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gif.Image = global::BilgisayarKontrol.Properties.Resources.Yükleniyor;
            this.gif.Location = new System.Drawing.Point(159, 127);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(44, 39);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif.TabIndex = 23;
            this.gif.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Location = new System.Drawing.Point(10, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 48);
            this.button1.TabIndex = 24;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(606, 185);
            this.ControlBox = false;
            this.Controls.Add(this.gif);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tamamtusu);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Kontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrol ";
            this.Load += new System.EventHandler(this.Kontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button tamamtusu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer örnektimer;
        private System.Windows.Forms.PictureBox gif;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer KontrolTimer;
    }
}