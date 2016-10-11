namespace BilgisayarKontrol
{
    partial class NetKes
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
            this.label1 = new System.Windows.Forms.Label();
            this.tamamtusu = new System.Windows.Forms.PictureBox();
            this.iptalettusu = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tamamtusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iptalettusu)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 27);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 32);
            this.label1.TabIndex = 33441;
            this.label1.Text = "İnternet baglantisi ne zaman kesilsin ?";
            // 
            // tamamtusu
            // 
            this.tamamtusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamamtusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6mkMqS;
            this.tamamtusu.Location = new System.Drawing.Point(352, 6);
            this.tamamtusu.Name = "tamamtusu";
            this.tamamtusu.Size = new System.Drawing.Size(50, 49);
            this.tamamtusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tamamtusu.TabIndex = 30;
            this.tamamtusu.TabStop = false;
            this.tamamtusu.Click += new System.EventHandler(this.tamamtusu_Click);
            // 
            // iptalettusu
            // 
            this.iptalettusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iptalettusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4rwvAD;
            this.iptalettusu.Location = new System.Drawing.Point(19, 6);
            this.iptalettusu.Name = "iptalettusu";
            this.iptalettusu.Size = new System.Drawing.Size(50, 48);
            this.iptalettusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iptalettusu.TabIndex = 29;
            this.iptalettusu.TabStop = false;
            this.iptalettusu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.iptalettusu);
            this.panel4.Controls.Add(this.tamamtusu);
            this.panel4.Location = new System.Drawing.Point(0, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 63);
            this.panel4.TabIndex = 33442;
            // 
            // NetKes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(414, 190);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "NetKes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamanlı Olarak İnterneti Kes";
            this.Load += new System.EventHandler(this.İnternetiKes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tamamtusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iptalettusu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox tamamtusu;
        private System.Windows.Forms.PictureBox iptalettusu;
        private System.Windows.Forms.Panel panel4;
    }
}