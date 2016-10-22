namespace BilgisayarKontrol
{
    partial class IslemListesi
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DevamEdenlerTusu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TamamTusu = new iTalk.iTalk_Button_2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "212",
            "12",
            "4",
            "124"});
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(552, 232);
            this.listBox1.TabIndex = 2;
            // 
            // DevamEdenlerTusu
            // 
            this.DevamEdenlerTusu.AutoSize = true;
            this.DevamEdenlerTusu.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DevamEdenlerTusu.ForeColor = System.Drawing.Color.Black;
            this.DevamEdenlerTusu.Location = new System.Drawing.Point(7, 10);
            this.DevamEdenlerTusu.Name = "DevamEdenlerTusu";
            this.DevamEdenlerTusu.Size = new System.Drawing.Size(140, 28);
            this.DevamEdenlerTusu.TabIndex = 33441;
            this.DevamEdenlerTusu.Text = "Devam edenler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 33443;
            this.label1.Text = "İptal edilebilir islemler";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.TamamTusu);
            this.panel4.Location = new System.Drawing.Point(0, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(595, 63);
            this.panel4.TabIndex = 33449;
            // 
            // TamamTusu
            // 
            this.TamamTusu.BackColor = System.Drawing.Color.Transparent;
            this.TamamTusu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TamamTusu.ForeColor = System.Drawing.Color.White;
            this.TamamTusu.Image = null;
            this.TamamTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TamamTusu.Location = new System.Drawing.Point(424, 9);
            this.TamamTusu.Name = "TamamTusu";
            this.TamamTusu.Size = new System.Drawing.Size(140, 40);
            this.TamamTusu.TabIndex = 33449;
            this.TamamTusu.Text = "Tamam";
            this.TamamTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33450;
            // 
            // IslemListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(577, 441);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DevamEdenlerTusu);
            this.Controls.Add(this.listBox1);
            this.Name = "IslemListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Islem Listesi";
            this.Load += new System.EventHandler(this.IslemListesi_Load);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label DevamEdenlerTusu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private iTalk.iTalk_Button_2 TamamTusu;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}