namespace BilgisayarKontrol
{
    partial class Giris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GirisTusu = new iTalk.iTalk_Button_2();
            this.sifreTXT = new iTalk.iTalk_TextBox_Big();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 33440;
            this.label2.Text = "Sifremi unuttum";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 33439;
            this.label1.Text = "Kullanıcı sifreniz ile giris yapınız";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6yirxO;
            this.pictureBox1.Location = new System.Drawing.Point(52, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 114);
            this.pictureBox1.TabIndex = 33438;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(-19, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 2);
            this.panel4.TabIndex = 33441;
            // 
            // GirisTusu
            // 
            this.GirisTusu.BackColor = System.Drawing.Color.Transparent;
            this.GirisTusu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.GirisTusu.ForeColor = System.Drawing.Color.White;
            this.GirisTusu.Image = global::BilgisayarKontrol.Properties.Resources.Forward_30;
            this.GirisTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GirisTusu.Location = new System.Drawing.Point(382, 177);
            this.GirisTusu.Name = "GirisTusu";
            this.GirisTusu.Size = new System.Drawing.Size(35, 43);
            this.GirisTusu.TabIndex = 33442;
            this.GirisTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GirisTusu.Click += new System.EventHandler(this.GirisTusu_Click);
            // 
            // sifreTXT
            // 
            this.sifreTXT.BackColor = System.Drawing.Color.Transparent;
            this.sifreTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.sifreTXT.ForeColor = System.Drawing.Color.DimGray;
            this.sifreTXT.Image = null;
            this.sifreTXT.Location = new System.Drawing.Point(82, 177);
            this.sifreTXT.MaxLength = 32767;
            this.sifreTXT.Multiline = false;
            this.sifreTXT.Name = "sifreTXT";
            this.sifreTXT.ReadOnly = false;
            this.sifreTXT.Size = new System.Drawing.Size(294, 41);
            this.sifreTXT.TabIndex = 33444;
            this.sifreTXT.Text = "1244";
            this.sifreTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.sifreTXT.UseSystemPasswordChar = true;
            this.sifreTXT.TextChanged += new System.EventHandler(this.sifreTXT_TextChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_1RBsZw;
            this.pictureBox6.Location = new System.Drawing.Point(432, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 58);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 33445;
            this.pictureBox6.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(508, 279);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.sifreTXT);
            this.Controls.Add(this.GirisTusu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private iTalk.iTalk_Button_2 GirisTusu;
        private iTalk.iTalk_TextBox_Big sifreTXT;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}