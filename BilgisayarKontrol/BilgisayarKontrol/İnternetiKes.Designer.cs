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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iptalettusu = new System.Windows.Forms.Button();
            this.tamamtusu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_7pDgxa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            // iptalettusu
            // 
            this.iptalettusu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iptalettusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalettusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.iptalettusu.Location = new System.Drawing.Point(12, 155);
            this.iptalettusu.Name = "iptalettusu";
            this.iptalettusu.Size = new System.Drawing.Size(429, 41);
            this.iptalettusu.TabIndex = 17;
            this.iptalettusu.Text = "İptal Et";
            this.iptalettusu.UseVisualStyleBackColor = false;
            this.iptalettusu.Click += new System.EventHandler(this.iptalettusu_Click);
            // 
            // tamamtusu
            // 
            this.tamamtusu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tamamtusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamamtusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tamamtusu.Location = new System.Drawing.Point(12, 109);
            this.tamamtusu.Name = "tamamtusu";
            this.tamamtusu.Size = new System.Drawing.Size(429, 40);
            this.tamamtusu.TabIndex = 16;
            this.tamamtusu.Text = "Tamam";
            this.tamamtusu.UseVisualStyleBackColor = false;
            this.tamamtusu.Click += new System.EventHandler(this.tamamtusu_Click);
            // 
            // NetKes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(461, 213);
            this.Controls.Add(this.iptalettusu);
            this.Controls.Add(this.tamamtusu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "NetKes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamanlı Olarak İnterneti Kes";
            this.Load += new System.EventHandler(this.İnternetiKes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button iptalettusu;
        private System.Windows.Forms.Button tamamtusu;
    }
}