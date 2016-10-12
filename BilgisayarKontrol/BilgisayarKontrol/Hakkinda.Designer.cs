namespace BilgisayarKontrol
{
    partial class Hakkinda
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
            this.WordpressTusu = new System.Windows.Forms.PictureBox();
            this.GitHubTusu = new System.Windows.Forms.PictureBox();
            this.KapatTusu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Versiyon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WordpressTusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubTusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KapatTusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WordpressTusu
            // 
            this.WordpressTusu.Cursor = System.Windows.Forms.Cursors.Help;
            this.WordpressTusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_1vlAoR;
            this.WordpressTusu.Location = new System.Drawing.Point(322, 201);
            this.WordpressTusu.Name = "WordpressTusu";
            this.WordpressTusu.Size = new System.Drawing.Size(51, 50);
            this.WordpressTusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WordpressTusu.TabIndex = 34;
            this.WordpressTusu.TabStop = false;
            this.WordpressTusu.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // GitHubTusu
            // 
            this.GitHubTusu.Cursor = System.Windows.Forms.Cursors.Help;
            this.GitHubTusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6tvHo8;
            this.GitHubTusu.Location = new System.Drawing.Point(258, 203);
            this.GitHubTusu.Name = "GitHubTusu";
            this.GitHubTusu.Size = new System.Drawing.Size(49, 48);
            this.GitHubTusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GitHubTusu.TabIndex = 33;
            this.GitHubTusu.TabStop = false;
            this.GitHubTusu.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // KapatTusu
            // 
            this.KapatTusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KapatTusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4rwvAD;
            this.KapatTusu.Location = new System.Drawing.Point(386, 203);
            this.KapatTusu.Name = "KapatTusu";
            this.KapatTusu.Size = new System.Drawing.Size(50, 48);
            this.KapatTusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.KapatTusu.TabIndex = 32;
            this.KapatTusu.TabStop = false;
            this.KapatTusu.Click += new System.EventHandler(this.iptalettusu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_8P9uR4;
            this.pictureBox1.Location = new System.Drawing.Point(27, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Versiyon
            // 
            this.Versiyon.AutoSize = true;
            this.Versiyon.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Versiyon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Versiyon.Location = new System.Drawing.Point(21, 145);
            this.Versiyon.Name = "Versiyon";
            this.Versiyon.Size = new System.Drawing.Size(49, 32);
            this.Versiyon.TabIndex = 33446;
            this.Versiyon.Text = "v1.1";
            // 
            // Hakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 263);
            this.ControlBox = false;
            this.Controls.Add(this.Versiyon);
            this.Controls.Add(this.WordpressTusu);
            this.Controls.Add(this.GitHubTusu);
            this.Controls.Add(this.KapatTusu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Hakkinda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.WordpressTusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubTusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KapatTusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox KapatTusu;
        private System.Windows.Forms.PictureBox GitHubTusu;
        private System.Windows.Forms.PictureBox WordpressTusu;
        private System.Windows.Forms.Label Versiyon;
    }
}