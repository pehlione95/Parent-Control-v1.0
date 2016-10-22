namespace BilgisayarKontrol
{
    partial class Yardim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yardim));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.göstermecombo = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TamamTusu = new iTalk.iTalk_Button_2();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(567, 137);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // göstermecombo
            // 
            this.göstermecombo.AutoSize = true;
            this.göstermecombo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.göstermecombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.göstermecombo.Location = new System.Drawing.Point(22, 18);
            this.göstermecombo.Name = "göstermecombo";
            this.göstermecombo.Size = new System.Drawing.Size(187, 24);
            this.göstermecombo.TabIndex = 4;
            this.göstermecombo.Text = "Bunu bir daha gösterme";
            this.göstermecombo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.TamamTusu);
            this.panel4.Controls.Add(this.göstermecombo);
            this.panel4.Location = new System.Drawing.Point(-10, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(618, 63);
            this.panel4.TabIndex = 33443;
            // 
            // TamamTusu
            // 
            this.TamamTusu.BackColor = System.Drawing.Color.Transparent;
            this.TamamTusu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TamamTusu.ForeColor = System.Drawing.Color.White;
            this.TamamTusu.Image = null;
            this.TamamTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TamamTusu.Location = new System.Drawing.Point(423, 9);
            this.TamamTusu.Name = "TamamTusu";
            this.TamamTusu.Size = new System.Drawing.Size(166, 40);
            this.TamamTusu.TabIndex = 33450;
            this.TamamTusu.Text = "Tamam";
            this.TamamTusu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TamamTusu.Click += new System.EventHandler(this.TamamTusu_Click);
            // 
            // Yardim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(597, 221);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "Yardim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Yardim";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Yardim_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.CheckBox göstermecombo;
        private System.Windows.Forms.Panel panel4;
        private iTalk.iTalk_Button_2 TamamTusu;
    }
}