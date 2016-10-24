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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TamamTusu = new iTalk.iTalk_Button_1();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mesajTXT = new iTalk.iTalk_TextBox_Small();
            this.baslikTXT = new iTalk.iTalk_TextBox_Small();
            this.comboBox1 = new iTalk.iTalk_ComboBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.TamamTusu);
            this.panel4.Location = new System.Drawing.Point(-8, 355);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 63);
            this.panel4.TabIndex = 33;
            // 
            // TamamTusu
            // 
            this.TamamTusu.BackColor = System.Drawing.Color.Transparent;
            this.TamamTusu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TamamTusu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TamamTusu.Image = null;
            this.TamamTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TamamTusu.Location = new System.Drawing.Point(41, 11);
            this.TamamTusu.Name = "TamamTusu";
            this.TamamTusu.Size = new System.Drawing.Size(348, 40);
            this.TamamTusu.TabIndex = 33450;
            this.TamamTusu.Text = "Tamam";
            this.TamamTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TamamTusu.Click += new System.EventHandler(this.TamamTusu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
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
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 33447;
            this.label1.Text = "Mesaj basligi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 33448;
            this.label3.Text = "Mesaj türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(27, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 32);
            this.label4.TabIndex = 33449;
            this.label4.Text = "Ne zaman gösterilsin ?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mesajTXT
            // 
            this.mesajTXT.BackColor = System.Drawing.Color.Transparent;
            this.mesajTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.mesajTXT.ForeColor = System.Drawing.Color.DimGray;
            this.mesajTXT.Location = new System.Drawing.Point(33, 51);
            this.mesajTXT.MaxLength = 32767;
            this.mesajTXT.Multiline = false;
            this.mesajTXT.Name = "mesajTXT";
            this.mesajTXT.ReadOnly = false;
            this.mesajTXT.Size = new System.Drawing.Size(348, 28);
            this.mesajTXT.TabIndex = 33450;
            this.mesajTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.mesajTXT.UseSystemPasswordChar = false;
            // 
            // baslikTXT
            // 
            this.baslikTXT.BackColor = System.Drawing.Color.Transparent;
            this.baslikTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.baslikTXT.ForeColor = System.Drawing.Color.DimGray;
            this.baslikTXT.Location = new System.Drawing.Point(33, 131);
            this.baslikTXT.MaxLength = 32767;
            this.baslikTXT.Multiline = false;
            this.baslikTXT.Name = "baslikTXT";
            this.baslikTXT.ReadOnly = false;
            this.baslikTXT.Size = new System.Drawing.Size(348, 28);
            this.baslikTXT.TabIndex = 33451;
            this.baslikTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.baslikTXT.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Items.AddRange(new object[] {
            "Uyarı",
            "Hata",
            "Bilgilendirme"});
            this.comboBox1.Location = new System.Drawing.Point(33, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 26);
            this.comboBox1.StartIndex = 0;
            this.comboBox1.TabIndex = 33452;
            // 
            // MesajGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(413, 416);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.baslikTXT);
            this.Controls.Add(this.mesajTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MesajGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj Göster";
            this.Load += new System.EventHandler(this.MesajGoster_Load);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private iTalk.iTalk_Button_1 TamamTusu;
        private iTalk.iTalk_TextBox_Small mesajTXT;
        private iTalk.iTalk_TextBox_Small baslikTXT;
        private iTalk.iTalk_ComboBox comboBox1;
    }
}