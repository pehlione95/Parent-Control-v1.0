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
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapattusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamam)).BeginInit();
            this.SuspendLayout();
            // 
            // güvenlikcevabiTXT
            // 
            this.güvenlikcevabiTXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güvenlikcevabiTXT.Location = new System.Drawing.Point(12, 64);
            this.güvenlikcevabiTXT.Name = "güvenlikcevabiTXT";
            this.güvenlikcevabiTXT.Size = new System.Drawing.Size(270, 27);
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
            this.kapattusu.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.tamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamam.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6mkMqS;
            this.tamam.Location = new System.Drawing.Point(262, 7);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(50, 49);
            this.tamam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tamam.TabIndex = 27;
            this.tamam.TabStop = false;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 32);
            this.label2.TabIndex = 33446;
            this.label2.Text = "Güvenlik cevabınızı yazınız";
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(299, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox güvenlikcevabiTXT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox tamam;
        private System.Windows.Forms.PictureBox kapattusu;
        private System.Windows.Forms.Label label2;
    }
}