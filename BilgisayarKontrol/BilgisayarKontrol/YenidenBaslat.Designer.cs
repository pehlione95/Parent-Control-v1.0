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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TamamTusu = new iTalk.iTalk_Button_1();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
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
            this.panel4.Controls.Add(this.TamamTusu);
            this.panel4.Location = new System.Drawing.Point(-14, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(477, 63);
            this.panel4.TabIndex = 33;
            // 
            // TamamTusu
            // 
            this.TamamTusu.BackColor = System.Drawing.Color.Transparent;
            this.TamamTusu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TamamTusu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TamamTusu.Image = null;
            this.TamamTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TamamTusu.Location = new System.Drawing.Point(32, 10);
            this.TamamTusu.Name = "TamamTusu";
            this.TamamTusu.Size = new System.Drawing.Size(420, 40);
            this.TamamTusu.TabIndex = 33448;
            this.TamamTusu.Text = "Tamam";
            this.TamamTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TamamTusu.Click += new System.EventHandler(this.TamamTusu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
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
            this.ClientSize = new System.Drawing.Size(457, 177);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private iTalk.iTalk_Button_1 TamamTusu;
    }
}