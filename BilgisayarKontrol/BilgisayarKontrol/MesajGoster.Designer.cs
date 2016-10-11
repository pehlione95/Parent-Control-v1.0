namespace BilgisayarKontrol
{
    partial class MesajGoster
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
            this.mesajTXT = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.baslikTXT = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iptalettusu = new System.Windows.Forms.PictureBox();
            this.tamam = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptalettusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamam)).BeginInit();
            this.SuspendLayout();
            // 
            // mesajTXT
            // 
            this.mesajTXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajTXT.Location = new System.Drawing.Point(33, 52);
            this.mesajTXT.Name = "mesajTXT";
            this.mesajTXT.Size = new System.Drawing.Size(348, 27);
            this.mesajTXT.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Uyarı",
            "Hata",
            "Bilgilendirme"});
            this.comboBox1.Location = new System.Drawing.Point(33, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 271);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // baslikTXT
            // 
            this.baslikTXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikTXT.Location = new System.Drawing.Point(33, 127);
            this.baslikTXT.Name = "baslikTXT";
            this.baslikTXT.Size = new System.Drawing.Size(348, 27);
            this.baslikTXT.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.iptalettusu);
            this.panel4.Controls.Add(this.tamam);
            this.panel4.Location = new System.Drawing.Point(-8, 316);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 63);
            this.panel4.TabIndex = 33;
            // 
            // iptalettusu
            // 
            this.iptalettusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iptalettusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4rwvAD;
            this.iptalettusu.Location = new System.Drawing.Point(41, 8);
            this.iptalettusu.Name = "iptalettusu";
            this.iptalettusu.Size = new System.Drawing.Size(50, 48);
            this.iptalettusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iptalettusu.TabIndex = 29;
            this.iptalettusu.TabStop = false;
            this.iptalettusu.Click += new System.EventHandler(this.iptal_Click);
            // 
            // tamam
            // 
            this.tamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamam.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6mkMqS;
            this.tamam.Location = new System.Drawing.Point(339, 8);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(50, 49);
            this.tamam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tamam.TabIndex = 30;
            this.tamam.TabStop = false;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(27, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 33446;
            this.label2.Text = "Gösterilecek mesaj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 33447;
            this.label1.Text = "Mesaj basligi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(30, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 33448;
            this.label3.Text = "Mesaj türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(30, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 32);
            this.label4.TabIndex = 33449;
            this.label4.Text = "Ne zaman gösterilsin ?";
            // 
            // MesajGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(413, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.baslikTXT);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mesajTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MesajGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj Göster";
            this.Load += new System.EventHandler(this.MesajGoster_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptalettusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mesajTXT;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox baslikTXT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox iptalettusu;
        private System.Windows.Forms.PictureBox tamam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}