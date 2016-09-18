namespace BilgisayarKontrol
{
    partial class BilgisayariKapat
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
            this.tamamtusu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iptalettusu = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tamamtusu
            // 
            this.tamamtusu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tamamtusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamamtusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tamamtusu.Location = new System.Drawing.Point(16, 98);
            this.tamamtusu.Name = "tamamtusu";
            this.tamamtusu.Size = new System.Drawing.Size(313, 35);
            this.tamamtusu.TabIndex = 3;
            this.tamamtusu.Text = "Tamam";
            this.tamamtusu.UseVisualStyleBackColor = false;
            this.tamamtusu.Click += new System.EventHandler(this.tamamtusu_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 2);
            this.panel1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // iptalettusu
            // 
            this.iptalettusu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iptalettusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalettusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.iptalettusu.Location = new System.Drawing.Point(16, 139);
            this.iptalettusu.Name = "iptalettusu";
            this.iptalettusu.Size = new System.Drawing.Size(313, 35);
            this.iptalettusu.TabIndex = 8;
            this.iptalettusu.Text = "İptal Et";
            this.iptalettusu.UseVisualStyleBackColor = false;
            this.iptalettusu.Click += new System.EventHandler(this.iptalettusu_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6xOIg2;
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(333, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // BilgisayariKapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(348, 187);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.iptalettusu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tamamtusu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "BilgisayariKapat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BilgisayariKapat";
            this.Load += new System.EventHandler(this.BilgisayariKapat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tamamtusu;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button iptalettusu;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}