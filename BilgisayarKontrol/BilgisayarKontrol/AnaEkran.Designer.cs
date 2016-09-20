namespace BilgisayarKontrol
{
    partial class AnaEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.TimerBilgisayariKapat = new System.Windows.Forms.Timer(this.components);
            this.anlikzamantimelabel = new System.Windows.Forms.Label();
            this.TimerAnlikZaman = new System.Windows.Forms.Timer(this.components);
            this.MesajGöster = new System.Windows.Forms.Timer(this.components);
            this.İnternetiKes = new System.Windows.Forms.Timer(this.components);
            this.YenidenBaslat = new System.Windows.Forms.Timer(this.components);
            this.AcilirMenü = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KapatmaEngeli = new System.Windows.Forms.Timer(this.components);
            this.Gizle = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.oyunengelletusu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cikistusu = new System.Windows.Forms.Button();
            this.İnternetiKesTusu = new System.Windows.Forms.Button();
            this.İnternetiYenileTusu = new System.Windows.Forms.Button();
            this.MesajGösterTusu = new System.Windows.Forms.Button();
            this.gizletusu = new System.Windows.Forms.Button();
            this.BilgisayariYenidenBaslatTusu = new System.Windows.Forms.Button();
            this.ZamanlıOlarakBilgisayariKapatBT = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TimerBelirlenenZamandanSonra = new System.Windows.Forms.Timer(this.components);
            this.TimerBelirlenenZamanaKadar = new System.Windows.Forms.Timer(this.components);
            this.kontrolpicture = new System.Windows.Forms.PictureBox();
            this.DevamEdenlerTusu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hakkindatusu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AcilirMenü.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevamEdenlerTusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hakkindatusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerBilgisayariKapat
            // 
            this.TimerBilgisayariKapat.Tick += new System.EventHandler(this.TimerBilgisayariKapat_Tick);
            // 
            // anlikzamantimelabel
            // 
            this.anlikzamantimelabel.AutoSize = true;
            this.anlikzamantimelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anlikzamantimelabel.ForeColor = System.Drawing.Color.Black;
            this.anlikzamantimelabel.Location = new System.Drawing.Point(133, 462);
            this.anlikzamantimelabel.Name = "anlikzamantimelabel";
            this.anlikzamantimelabel.Size = new System.Drawing.Size(140, 25);
            this.anlikzamantimelabel.TabIndex = 11;
            this.anlikzamantimelabel.Text = "Bilgi Alınıyor ....";
            this.anlikzamantimelabel.Click += new System.EventHandler(this.anlikzamantimelabel_Click);
            // 
            // TimerAnlikZaman
            // 
            this.TimerAnlikZaman.Tick += new System.EventHandler(this.TimerAnlikZaman_Tick);
            // 
            // MesajGöster
            // 
            this.MesajGöster.Tick += new System.EventHandler(this.MesajGöster_Tick);
            // 
            // İnternetiKes
            // 
            this.İnternetiKes.Tick += new System.EventHandler(this.İnternetiKes_Tick);
            // 
            // YenidenBaslat
            // 
            this.YenidenBaslat.Tick += new System.EventHandler(this.YenidenBaslat_Tick);
            // 
            // AcilirMenü
            // 
            this.AcilirMenü.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem});
            this.AcilirMenü.Name = "AcilirMenü";
            this.AcilirMenü.Size = new System.Drawing.Size(145, 26);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.gösterToolStripMenuItem.Text = "Göster / Gizle";
            // 
            // KapatmaEngeli
            // 
            this.KapatmaEngeli.Tick += new System.EventHandler(this.KapatmaEngeli_Tick);
            // 
            // Gizle
            // 
            this.Gizle.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Gizle.BalloonTipText = "Samet UCA";
            this.Gizle.BalloonTipTitle = "Baslik";
            this.Gizle.ContextMenuStrip = this.AcilirMenü;
            this.Gizle.Icon = ((System.Drawing.Icon)(resources.GetObject("Gizle.Icon")));
            this.Gizle.Text = "S-Ebeveyn Kontrol";
            this.Gizle.Visible = true;
            this.Gizle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Gizle_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.oyunengelletusu);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.cikistusu);
            this.panel3.Controls.Add(this.İnternetiKesTusu);
            this.panel3.Controls.Add(this.İnternetiYenileTusu);
            this.panel3.Controls.Add(this.MesajGösterTusu);
            this.panel3.Controls.Add(this.gizletusu);
            this.panel3.Controls.Add(this.BilgisayariYenidenBaslatTusu);
            this.panel3.Controls.Add(this.ZamanlıOlarakBilgisayariKapatBT);
            this.panel3.Location = new System.Drawing.Point(-15, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 289);
            this.panel3.TabIndex = 33;
            // 
            // oyunengelletusu
            // 
            this.oyunengelletusu.BackColor = System.Drawing.Color.Azure;
            this.oyunengelletusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oyunengelletusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oyunengelletusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.oyunengelletusu.Image = ((System.Drawing.Image)(resources.GetObject("oyunengelletusu.Image")));
            this.oyunengelletusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oyunengelletusu.Location = new System.Drawing.Point(27, 210);
            this.oyunengelletusu.Name = "oyunengelletusu";
            this.oyunengelletusu.Size = new System.Drawing.Size(284, 58);
            this.oyunengelletusu.TabIndex = 28;
            this.oyunengelletusu.Text = "Uygulama / Oyun Engelle";
            this.oyunengelletusu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.oyunengelletusu.UseVisualStyleBackColor = true;
            this.oyunengelletusu.Click += new System.EventHandler(this.oyunengelletusu_Click);
            this.oyunengelletusu.MouseEnter += new System.EventHandler(this.oyunengelletusu_MouseEnter);
            this.oyunengelletusu.MouseLeave += new System.EventHandler(this.oyunengelletusu_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(15, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 2);
            this.panel1.TabIndex = 0;
            // 
            // cikistusu
            // 
            this.cikistusu.BackColor = System.Drawing.Color.Azure;
            this.cikistusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikistusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikistusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cikistusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_7gV4IG;
            this.cikistusu.Location = new System.Drawing.Point(502, 146);
            this.cikistusu.Name = "cikistusu";
            this.cikistusu.Size = new System.Drawing.Size(134, 58);
            this.cikistusu.TabIndex = 27;
            this.cikistusu.Text = "Kapat";
            this.cikistusu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikistusu.UseVisualStyleBackColor = true;
            this.cikistusu.Click += new System.EventHandler(this.cikistusu_Click);
            this.cikistusu.MouseEnter += new System.EventHandler(this.cikistusu_MouseEnter);
            this.cikistusu.MouseLeave += new System.EventHandler(this.cikistusu_MouseLeave);
            // 
            // İnternetiKesTusu
            // 
            this.İnternetiKesTusu.BackColor = System.Drawing.Color.Azure;
            this.İnternetiKesTusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.İnternetiKesTusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.İnternetiKesTusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.İnternetiKesTusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_8lh57r;
            this.İnternetiKesTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.İnternetiKesTusu.Location = new System.Drawing.Point(27, 146);
            this.İnternetiKesTusu.Name = "İnternetiKesTusu";
            this.İnternetiKesTusu.Size = new System.Drawing.Size(284, 58);
            this.İnternetiKesTusu.TabIndex = 4;
            this.İnternetiKesTusu.Text = "Zamanlı Olarak İnterneti Kes";
            this.İnternetiKesTusu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.İnternetiKesTusu.UseVisualStyleBackColor = true;
            this.İnternetiKesTusu.Click += new System.EventHandler(this.İnternetiKesTusu_Click);
            this.İnternetiKesTusu.MouseEnter += new System.EventHandler(this.İnternetiKesTusu_MouseEnter);
            this.İnternetiKesTusu.MouseLeave += new System.EventHandler(this.İnternetiKesTusu_MouseLeave);
            // 
            // İnternetiYenileTusu
            // 
            this.İnternetiYenileTusu.BackColor = System.Drawing.Color.Azure;
            this.İnternetiYenileTusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.İnternetiYenileTusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.İnternetiYenileTusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.İnternetiYenileTusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_8lh57r;
            this.İnternetiYenileTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.İnternetiYenileTusu.Location = new System.Drawing.Point(27, 82);
            this.İnternetiYenileTusu.Name = "İnternetiYenileTusu";
            this.İnternetiYenileTusu.Size = new System.Drawing.Size(284, 58);
            this.İnternetiYenileTusu.TabIndex = 3;
            this.İnternetiYenileTusu.Text = "Zamanlı Olarak İnternet Erişimi\r\n";
            this.İnternetiYenileTusu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.İnternetiYenileTusu.UseVisualStyleBackColor = true;
            this.İnternetiYenileTusu.MouseEnter += new System.EventHandler(this.İnternetiYenileTusu_MouseEnter);
            this.İnternetiYenileTusu.MouseLeave += new System.EventHandler(this.İnternetiYenileTusu_MouseLeave);
            // 
            // MesajGösterTusu
            // 
            this.MesajGösterTusu.BackColor = System.Drawing.Color.Azure;
            this.MesajGösterTusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MesajGösterTusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MesajGösterTusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.MesajGösterTusu.Image = ((System.Drawing.Image)(resources.GetObject("MesajGösterTusu.Image")));
            this.MesajGösterTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MesajGösterTusu.Location = new System.Drawing.Point(343, 82);
            this.MesajGösterTusu.Name = "MesajGösterTusu";
            this.MesajGösterTusu.Size = new System.Drawing.Size(293, 58);
            this.MesajGösterTusu.TabIndex = 5;
            this.MesajGösterTusu.Text = "Zamanlı Olarak Mesaj Göster";
            this.MesajGösterTusu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MesajGösterTusu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MesajGösterTusu.UseVisualStyleBackColor = true;
            this.MesajGösterTusu.Click += new System.EventHandler(this.MesajGösterTusu_Click);
            this.MesajGösterTusu.MouseEnter += new System.EventHandler(this.MesajGösterTusu_MouseEnter);
            this.MesajGösterTusu.MouseLeave += new System.EventHandler(this.MesajGösterTusu_MouseLeave);
            // 
            // gizletusu
            // 
            this.gizletusu.BackColor = System.Drawing.Color.Azure;
            this.gizletusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gizletusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gizletusu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gizletusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_1n8nOU;
            this.gizletusu.Location = new System.Drawing.Point(343, 146);
            this.gizletusu.Name = "gizletusu";
            this.gizletusu.Size = new System.Drawing.Size(153, 58);
            this.gizletusu.TabIndex = 6;
            this.gizletusu.Text = "Gizle";
            this.gizletusu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gizletusu.UseVisualStyleBackColor = true;
            this.gizletusu.Click += new System.EventHandler(this.gizletusu_Click);
            this.gizletusu.MouseEnter += new System.EventHandler(this.gizletusu_MouseEnter);
            this.gizletusu.MouseLeave += new System.EventHandler(this.gizletusu_MouseLeave);
            // 
            // BilgisayariYenidenBaslatTusu
            // 
            this.BilgisayariYenidenBaslatTusu.BackColor = System.Drawing.Color.Azure;
            this.BilgisayariYenidenBaslatTusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BilgisayariYenidenBaslatTusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BilgisayariYenidenBaslatTusu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgisayariYenidenBaslatTusu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BilgisayariYenidenBaslatTusu.Image = ((System.Drawing.Image)(resources.GetObject("BilgisayariYenidenBaslatTusu.Image")));
            this.BilgisayariYenidenBaslatTusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BilgisayariYenidenBaslatTusu.Location = new System.Drawing.Point(343, 18);
            this.BilgisayariYenidenBaslatTusu.Name = "BilgisayariYenidenBaslatTusu";
            this.BilgisayariYenidenBaslatTusu.Size = new System.Drawing.Size(293, 58);
            this.BilgisayariYenidenBaslatTusu.TabIndex = 2;
            this.BilgisayariYenidenBaslatTusu.Text = "Zamanlı Bilgisayarı Yeniden Başlat";
            this.BilgisayariYenidenBaslatTusu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BilgisayariYenidenBaslatTusu.UseVisualStyleBackColor = false;
            this.BilgisayariYenidenBaslatTusu.Click += new System.EventHandler(this.BilgisayariYenidenBaslatTusu_Click);
            this.BilgisayariYenidenBaslatTusu.MouseEnter += new System.EventHandler(this.BilgisayariYenidenBaslatTusu_MouseEnter);
            this.BilgisayariYenidenBaslatTusu.MouseLeave += new System.EventHandler(this.BilgisayariYenidenBaslatTusu_MouseLeave);
            // 
            // ZamanlıOlarakBilgisayariKapatBT
            // 
            this.ZamanlıOlarakBilgisayariKapatBT.BackColor = System.Drawing.Color.Azure;
            this.ZamanlıOlarakBilgisayariKapatBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZamanlıOlarakBilgisayariKapatBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZamanlıOlarakBilgisayariKapatBT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ZamanlıOlarakBilgisayariKapatBT.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_8lh57r;
            this.ZamanlıOlarakBilgisayariKapatBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZamanlıOlarakBilgisayariKapatBT.Location = new System.Drawing.Point(27, 18);
            this.ZamanlıOlarakBilgisayariKapatBT.Name = "ZamanlıOlarakBilgisayariKapatBT";
            this.ZamanlıOlarakBilgisayariKapatBT.Size = new System.Drawing.Size(284, 58);
            this.ZamanlıOlarakBilgisayariKapatBT.TabIndex = 1;
            this.ZamanlıOlarakBilgisayariKapatBT.Text = "Zamanlı Olarak Bilgisayarı Kapat";
            this.ZamanlıOlarakBilgisayariKapatBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ZamanlıOlarakBilgisayariKapatBT.UseVisualStyleBackColor = true;
            this.ZamanlıOlarakBilgisayariKapatBT.Click += new System.EventHandler(this.ZamanlıOlarakBilgisayariKapatBT_Click);
            this.ZamanlıOlarakBilgisayariKapatBT.MouseEnter += new System.EventHandler(this.ZamanlıOlarakBilgisayariKapatBT_MouseEnter);
            this.ZamanlıOlarakBilgisayariKapatBT.MouseLeave += new System.EventHandler(this.ZamanlıOlarakBilgisayariKapatBT_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(-16, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 2);
            this.panel4.TabIndex = 8;
            // 
            // TimerBelirlenenZamandanSonra
            // 
            this.TimerBelirlenenZamandanSonra.Tick += new System.EventHandler(this.TimerBelirlenenZamandanSonra_Tick);
            // 
            // TimerBelirlenenZamanaKadar
            // 
            this.TimerBelirlenenZamanaKadar.Tick += new System.EventHandler(this.TimerBelirlenenZamanaKadar_Tick);
            // 
            // kontrolpicture
            // 
            this.kontrolpicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kontrolpicture.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_0HUgyl;
            this.kontrolpicture.Location = new System.Drawing.Point(583, 457);
            this.kontrolpicture.Name = "kontrolpicture";
            this.kontrolpicture.Size = new System.Drawing.Size(38, 33);
            this.kontrolpicture.TabIndex = 26;
            this.kontrolpicture.TabStop = false;
            this.kontrolpicture.Click += new System.EventHandler(this.kontrolpicture_Click);
            // 
            // DevamEdenlerTusu
            // 
            this.DevamEdenlerTusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DevamEdenlerTusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_9IaPOJ2;
            this.DevamEdenlerTusu.Location = new System.Drawing.Point(122, 119);
            this.DevamEdenlerTusu.Name = "DevamEdenlerTusu";
            this.DevamEdenlerTusu.Size = new System.Drawing.Size(124, 35);
            this.DevamEdenlerTusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DevamEdenlerTusu.TabIndex = 19;
            this.DevamEdenlerTusu.TabStop = false;
            this.DevamEdenlerTusu.Click += new System.EventHandler(this.DevamEdenlerTusu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_0RZKkL;
            this.pictureBox2.Location = new System.Drawing.Point(95, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // hakkindatusu
            // 
            this.hakkindatusu.Cursor = System.Windows.Forms.Cursors.Help;
            this.hakkindatusu.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_4S23B6;
            this.hakkindatusu.Location = new System.Drawing.Point(-16, 120);
            this.hakkindatusu.Name = "hakkindatusu";
            this.hakkindatusu.Size = new System.Drawing.Size(144, 35);
            this.hakkindatusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hakkindatusu.TabIndex = 15;
            this.hakkindatusu.TabStop = false;
            this.hakkindatusu.Click += new System.EventHandler(this.hakkindatusu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_6yirxO;
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BilgisayarKontrol.Properties.Resources.Logomakr_2jrqjS;
            this.pictureBox3.Location = new System.Drawing.Point(12, 458);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(634, 496);
            this.ControlBox = false;
            this.Controls.Add(this.kontrolpicture);
            this.Controls.Add(this.DevamEdenlerTusu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hakkindatusu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.anlikzamantimelabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AnaEkran";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-Ebeveyn Kontrol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaEkran_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaEkran_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AcilirMenü.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kontrolpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevamEdenlerTusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hakkindatusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZamanlıOlarakBilgisayariKapatBT;
        private System.Windows.Forms.Button BilgisayariYenidenBaslatTusu;
        private System.Windows.Forms.Button İnternetiYenileTusu;
        private System.Windows.Forms.Button İnternetiKesTusu;
        private System.Windows.Forms.Button MesajGösterTusu;
        public System.Windows.Forms.Timer TimerBilgisayariKapat;
        private System.Windows.Forms.Label anlikzamantimelabel;
        private System.Windows.Forms.Timer TimerAnlikZaman;
        private System.Windows.Forms.Button gizletusu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hakkindatusu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox DevamEdenlerTusu;
        public System.Windows.Forms.Timer MesajGöster;
        public System.Windows.Forms.Timer İnternetiKes;
        public System.Windows.Forms.Timer YenidenBaslat;
        private System.Windows.Forms.PictureBox kontrolpicture;
        private System.Windows.Forms.ContextMenuStrip AcilirMenü;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.Button cikistusu;
        private System.Windows.Forms.Timer KapatmaEngeli;
        private System.Windows.Forms.NotifyIcon Gizle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button oyunengelletusu;
        public System.Windows.Forms.Timer TimerBelirlenenZamandanSonra;
        public System.Windows.Forms.Timer TimerBelirlenenZamanaKadar;
    }
}

