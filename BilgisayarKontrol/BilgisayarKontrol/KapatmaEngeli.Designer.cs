namespace BilgisayarKontrol
{
    partial class KapatmaEngeli
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kapattusu = new System.Windows.Forms.PictureBox();
            this.tamamtusu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapattusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamamtusu)).BeginInit();
            this.SuspendLayout();
            // 
            // sifreTXT
            // 
            this.sifreTXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTXT.Location = new System.Drawing.Point(12, 84);
            this.sifreTXT.Name = "sifreTXT";
            this.sifreTXT.PasswordChar = '*';
            this.sifreTXT.Size = new System.Drawing.Size(240, 27);
            this.sifreTXT.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_9mge1J;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.kapattusu);
            this.panel4.Controls.Add(this.tamamtusu);
            this.panel4.Location = new System.Drawing.Point(-4, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 63);
            this.panel4.TabIndex = 32;
            // 
            // kapattusu
            // 
            this.kapattusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4rwvAD;
            this.kapattusu.Location = new System.Drawing.Point(16, 6);
            this.kapattusu.Name = "kapattusu";
            this.kapattusu.Size = new System.Drawing.Size(50, 48);
            this.kapattusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kapattusu.TabIndex = 29;
            this.kapattusu.TabStop = false;
            this.kapattusu.Click += new System.EventHandler(this.kapattusu_Click);
            // 
            // tamamtusu
            // 
            this.tamamtusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6mkMqS;
            this.tamamtusu.Location = new System.Drawing.Point(206, 6);
            this.tamamtusu.Name = "tamamtusu";
            this.tamamtusu.Size = new System.Drawing.Size(50, 49);
            this.tamamtusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tamamtusu.TabIndex = 30;
            this.tamamtusu.TabStop = false;
            this.tamamtusu.Click += new System.EventHandler(this.tamamtusu_Click);
            // 
            // KapatmaEngeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(275, 225);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifreTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KapatmaEngeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KapatmaEngeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapattusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamamtusu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifreTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox kapattusu;
        private System.Windows.Forms.PictureBox tamamtusu;
    }
}