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
            this.baslattusu = new System.Windows.Forms.Button();
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
            this.tamamtusu.BackColor = System.Drawing.Color.Azure;
            this.tamamtusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamamtusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tamamtusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tamamtusu.Location = new System.Drawing.Point(386, 122);
            this.tamamtusu.Name = "tamamtusu";
            this.tamamtusu.Size = new System.Drawing.Size(202, 48);
            this.tamamtusu.TabIndex = 13;
            this.tamamtusu.Text = "Kapat";
            this.tamamtusu.UseVisualStyleBackColor = false;
            this.tamamtusu.Click += new System.EventHandler(this.tamamtusu_Click);
            this.tamamtusu.MouseEnter += new System.EventHandler(this.tamamtusu_MouseEnter);
            this.tamamtusu.MouseLeave += new System.EventHandler(this.tamamtusu_MouseLeave);
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
            this.gif.BackColor = System.Drawing.Color.Azure;
            this.gif.Image = global::BilgisayarKontrol.Properties.Resources.Yükleniyor;
            this.gif.Location = new System.Drawing.Point(159, 127);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(44, 39);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif.TabIndex = 23;
            this.gif.TabStop = false;
            this.gif.MouseEnter += new System.EventHandler(this.gif_MouseEnter);
            this.gif.MouseLeave += new System.EventHandler(this.gif_MouseLeave);
            // 
            // baslattusu
            // 
            this.baslattusu.BackColor = System.Drawing.Color.Azure;
            this.baslattusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baslattusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.baslattusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.baslattusu.Location = new System.Drawing.Point(12, 122);
            this.baslattusu.Name = "baslattusu";
            this.baslattusu.Size = new System.Drawing.Size(202, 48);
            this.baslattusu.TabIndex = 24;
            this.baslattusu.Text = "Baslat";
            this.baslattusu.UseVisualStyleBackColor = false;
            this.baslattusu.Click += new System.EventHandler(this.baslattusu_Click);
            this.baslattusu.MouseEnter += new System.EventHandler(this.baslattusu_MouseEnter);
            this.baslattusu.MouseLeave += new System.EventHandler(this.baslattusu_MouseLeave);
            // 
            // Kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(606, 185);
            this.ControlBox = false;
            this.Controls.Add(this.gif);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tamamtusu);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baslattusu);
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
        public System.Windows.Forms.Timer KontrolTimer;
        private System.Windows.Forms.Button baslattusu;
    }
}