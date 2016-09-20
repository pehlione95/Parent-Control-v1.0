namespace BilgisayarKontrol
{
    partial class Reboot
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
            this.iptalettusu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tamamtusu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // iptalettusu
            // 
            this.iptalettusu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iptalettusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalettusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.iptalettusu.Location = new System.Drawing.Point(16, 146);
            this.iptalettusu.Name = "iptalettusu";
            this.iptalettusu.Size = new System.Drawing.Size(422, 35);
            this.iptalettusu.TabIndex = 23;
            this.iptalettusu.Text = "İptal Et";
            this.iptalettusu.UseVisualStyleBackColor = false;
            this.iptalettusu.Click += new System.EventHandler(this.iptalettusu_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 2);
            this.panel1.TabIndex = 22;
            // 
            // tamamtusu
            // 
            this.tamamtusu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tamamtusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamamtusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tamamtusu.Location = new System.Drawing.Point(16, 105);
            this.tamamtusu.Name = "tamamtusu";
            this.tamamtusu.Size = new System.Drawing.Size(422, 35);
            this.tamamtusu.TabIndex = 21;
            this.tamamtusu.Text = "Tamam";
            this.tamamtusu.UseVisualStyleBackColor = false;
            this.tamamtusu.Click += new System.EventHandler(this.tamamtusu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 27);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_8Dri84;
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(430, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // Reboot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(450, 189);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.iptalettusu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tamamtusu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Reboot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeniden Baslat";
            this.Load += new System.EventHandler(this.YenidenBaslat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button iptalettusu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tamamtusu;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}