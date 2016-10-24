namespace BilgisayarKontrol
{
    partial class KapatmaEngeli
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
            this.label2 = new System.Windows.Forms.Label();
            this.sifreTXT = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.TamamTusu = new iTalk.iTalk_Button_1();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.iTalk_Button_11);
            this.panel4.Controls.Add(this.TamamTusu);
            this.panel4.Location = new System.Drawing.Point(-4, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 112);
            this.panel4.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 32);
            this.label2.TabIndex = 33446;
            this.label2.Text = "Yönetici sifresini yaziniz";
            // 
            // sifreTXT
            // 
            this.sifreTXT.BackColor = System.Drawing.Color.Transparent;
            this.sifreTXT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.sifreTXT.ForeColor = System.Drawing.Color.DimGray;
            this.sifreTXT.Location = new System.Drawing.Point(12, 64);
            this.sifreTXT.MaxLength = 32767;
            this.sifreTXT.Multiline = false;
            this.sifreTXT.Name = "sifreTXT";
            this.sifreTXT.ReadOnly = false;
            this.sifreTXT.Size = new System.Drawing.Size(239, 28);
            this.sifreTXT.TabIndex = 33447;
            this.sifreTXT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.sifreTXT.UseSystemPasswordChar = true;
            this.sifreTXT.TextChanged += new System.EventHandler(this.sifreTXT_TextChanged);
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.iTalk_Button_11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(16, 57);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(239, 40);
            this.iTalk_Button_11.TabIndex = 33456;
            this.iTalk_Button_11.Text = "Vazgeç";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // TamamTusu
            // 
            this.TamamTusu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TamamTusu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TamamTusu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TamamTusu.Image = null;
            this.TamamTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TamamTusu.Location = new System.Drawing.Point(16, 11);
            this.TamamTusu.Name = "TamamTusu";
            this.TamamTusu.Size = new System.Drawing.Size(239, 40);
            this.TamamTusu.TabIndex = 33455;
            this.TamamTusu.Text = "Çıkış";
            this.TamamTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TamamTusu.Click += new System.EventHandler(this.TamamTusu_Click);
            // 
            // KapatmaEngeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(263, 219);
            this.ControlBox = false;
            this.Controls.Add(this.sifreTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KapatmaEngeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KapatmaEngeli_Load);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private iTalk.iTalk_Button_1 iTalk_Button_11;
        private iTalk.iTalk_Button_1 TamamTusu;
        private iTalk.iTalk_TextBox_Small sifreTXT;
    }
}