namespace BilgisayarKontrol
{
    partial class UygulamaEngelle
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
            this.belirlenenzamanakadarradio = new System.Windows.Forms.RadioButton();
            this.belirlenenzamandansonraradio = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DosyaSec = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uygulamadiTXT = new iTalk.iTalk_TextBox_Small();
            this.TamamTusu = new iTalk.iTalk_Button_1();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DosyaSec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.TamamTusu);
            this.panel4.Location = new System.Drawing.Point(-7, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 63);
            this.panel4.TabIndex = 33;
            // 
            // belirlenenzamanakadarradio
            // 
            this.belirlenenzamanakadarradio.AutoSize = true;
            this.belirlenenzamanakadarradio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.belirlenenzamanakadarradio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.belirlenenzamanakadarradio.Location = new System.Drawing.Point(34, 10);
            this.belirlenenzamanakadarradio.Name = "belirlenenzamanakadarradio";
            this.belirlenenzamanakadarradio.Size = new System.Drawing.Size(254, 23);
            this.belirlenenzamanakadarradio.TabIndex = 36;
            this.belirlenenzamanakadarradio.TabStop = true;
            this.belirlenenzamanakadarradio.Text = "Belirlenen zamana kadar engelle";
            this.belirlenenzamanakadarradio.UseVisualStyleBackColor = true;
            this.belirlenenzamanakadarradio.CheckedChanged += new System.EventHandler(this.belirlenenzamanakadarradio_CheckedChanged);
            // 
            // belirlenenzamandansonraradio
            // 
            this.belirlenenzamandansonraradio.AutoSize = true;
            this.belirlenenzamandansonraradio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.belirlenenzamandansonraradio.Checked = true;
            this.belirlenenzamandansonraradio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.belirlenenzamandansonraradio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.belirlenenzamandansonraradio.Location = new System.Drawing.Point(33, 11);
            this.belirlenenzamandansonraradio.Name = "belirlenenzamandansonraradio";
            this.belirlenenzamandansonraradio.Size = new System.Drawing.Size(272, 23);
            this.belirlenenzamandansonraradio.TabIndex = 37;
            this.belirlenenzamandansonraradio.TabStop = true;
            this.belirlenenzamandansonraradio.Text = "Belirlenen zamandan sonra engelle";
            this.belirlenenzamandansonraradio.UseVisualStyleBackColor = false;
            this.belirlenenzamandansonraradio.CheckedChanged += new System.EventHandler(this.belirlenenzamandansonraradio_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 27);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.belirlenenzamanakadarradio);
            this.panel1.Location = new System.Drawing.Point(-7, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 46);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.belirlenenzamandansonraradio);
            this.panel2.Location = new System.Drawing.Point(-7, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 46);
            this.panel2.TabIndex = 40;
            // 
            // DosyaSec
            // 
            this.DosyaSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DosyaSec.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_7tiwvB;
            this.DosyaSec.Location = new System.Drawing.Point(360, 65);
            this.DosyaSec.Name = "DosyaSec";
            this.DosyaSec.Size = new System.Drawing.Size(31, 27);
            this.DosyaSec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DosyaSec.TabIndex = 34;
            this.DosyaSec.TabStop = false;
            this.DosyaSec.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 32);
            this.label2.TabIndex = 33446;
            this.label2.Text = "Engellenecek uygulama / oyun seciniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 33447;
            this.label1.Text = "Ne zaman engellenecek ?";
            // 
            // uygulamadiTXT
            // 
            this.uygulamadiTXT.BackColor = System.Drawing.Color.Transparent;
            this.uygulamadiTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.uygulamadiTXT.ForeColor = System.Drawing.Color.DimGray;
            this.uygulamadiTXT.Location = new System.Drawing.Point(27, 65);
            this.uygulamadiTXT.MaxLength = 32767;
            this.uygulamadiTXT.Multiline = false;
            this.uygulamadiTXT.Name = "uygulamadiTXT";
            this.uygulamadiTXT.ReadOnly = false;
            this.uygulamadiTXT.Size = new System.Drawing.Size(326, 28);
            this.uygulamadiTXT.TabIndex = 33448;
            this.uygulamadiTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uygulamadiTXT.UseSystemPasswordChar = false;
            // 
            // TamamTusu
            // 
            this.TamamTusu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TamamTusu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TamamTusu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TamamTusu.Image = null;
            this.TamamTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TamamTusu.Location = new System.Drawing.Point(33, 11);
            this.TamamTusu.Name = "TamamTusu";
            this.TamamTusu.Size = new System.Drawing.Size(384, 40);
            this.TamamTusu.TabIndex = 33456;
            this.TamamTusu.Text = "Tamam";
            this.TamamTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TamamTusu.Click += new System.EventHandler(this.TamamTusu_Click);
            // 
            // UygulamaEngelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(440, 364);
            this.Controls.Add(this.uygulamadiTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DosyaSec);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "UygulamaEngelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulama / Oyun Engelle";
            this.Load += new System.EventHandler(this.UygulamaEngelle_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DosyaSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox DosyaSec;
        private System.Windows.Forms.RadioButton belirlenenzamanakadarradio;
        private System.Windows.Forms.RadioButton belirlenenzamandansonraradio;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private iTalk.iTalk_TextBox_Small uygulamadiTXT;
        private iTalk.iTalk_Button_1 TamamTusu;
    }
}