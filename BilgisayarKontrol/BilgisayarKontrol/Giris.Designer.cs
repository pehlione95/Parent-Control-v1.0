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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sifreTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Giristusu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.sifreTXT);
            this.panel1.Location = new System.Drawing.Point(81, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 43);
            this.panel1.TabIndex = 33436;
            // 
            // sifreTXT
            // 
            this.sifreTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifreTXT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sifreTXT.Location = new System.Drawing.Point(6, 15);
            this.sifreTXT.Name = "sifreTXT";
            this.sifreTXT.PasswordChar = '*';
            this.sifreTXT.Size = new System.Drawing.Size(289, 20);
            this.sifreTXT.TabIndex = 2;
            this.sifreTXT.Text = "1244";
            this.sifreTXT.TextChanged += new System.EventHandler(this.sifreTXT_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 33439;
            this.label1.Text = "Kullanıcı bilgileriniz ile giris yapınız";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6yirxO;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33438;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Giristusu
            // 
            this.Giristusu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.Giristusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Giristusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Giristusu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giristusu.ForeColor = System.Drawing.Color.Black;
            this.Giristusu.Image = global::BilgisayarKontrol.Properties.Resources.Forward_30;
            this.Giristusu.Location = new System.Drawing.Point(382, 177);
            this.Giristusu.Name = "Giristusu";
            this.Giristusu.Size = new System.Drawing.Size(60, 43);
            this.Giristusu.TabIndex = 33437;
            this.Giristusu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Giristusu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Giristusu.UseVisualStyleBackColor = false;
            this.Giristusu.Click += new System.EventHandler(this.Giristusu_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(-19, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 5);
            this.panel4.TabIndex = 33441;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(527, 279);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Giristusu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox sifreTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Giristusu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}