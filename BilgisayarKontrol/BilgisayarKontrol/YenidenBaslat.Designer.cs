﻿namespace BilgisayarKontrol
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iptalettusu = new System.Windows.Forms.PictureBox();
            this.tamam = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptalettusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamam)).BeginInit();
            this.SuspendLayout();
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.iptalettusu);
            this.panel4.Controls.Add(this.tamam);
            this.panel4.Location = new System.Drawing.Point(-14, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(477, 63);
            this.panel4.TabIndex = 33;
            // 
            // iptalettusu
            // 
            this.iptalettusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iptalettusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4rwvAD;
            this.iptalettusu.Location = new System.Drawing.Point(30, 6);
            this.iptalettusu.Name = "iptalettusu";
            this.iptalettusu.Size = new System.Drawing.Size(50, 48);
            this.iptalettusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iptalettusu.TabIndex = 29;
            this.iptalettusu.TabStop = false;
            this.iptalettusu.Click += new System.EventHandler(this.iptalettusu_Click);
            // 
            // tamam
            // 
            this.tamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamam.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6mkMqS;
            this.tamam.Location = new System.Drawing.Point(402, 6);
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
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 32);
            this.label2.TabIndex = 33446;
            this.label2.Text = "Bilgisayar ne zaman yeniden baslatilsin ?";
            // 
            // Reboot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(450, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Reboot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeniden Baslat";
            this.Load += new System.EventHandler(this.YenidenBaslat_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptalettusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox iptalettusu;
        private System.Windows.Forms.PictureBox tamam;
        private System.Windows.Forms.Label label2;
    }
}