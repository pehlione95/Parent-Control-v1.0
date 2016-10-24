using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace BilgisayarKontrol
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        public static string sistemsaati;
        public static string ilkacilis;
        private void Form1_Load(object sender, EventArgs e)
        {
            kadilabel.Text = "Merhaba, " + KullaniciBilgileri.Default.KullaniciAdi+".";
            TimerAnlikZaman.Interval = 1000;
            TimerAnlikZaman.Start();
            if (Settings1.Default.GörevYöneticisiEngellensinmi == 1)
            {
                TimerGörevYöneticisiEngelle.Interval = 1000;
                TimerGörevYöneticisiEngelle.Start();
            }
            if(Settings1.Default.CmdEngellensinmi==1)
            {
                TimerCmdEngelle.Interval = 1000;
                TimerCmdEngelle.Start();
            }
            if(Settings1.Default.RunEngellensinmi==1)
            {
                TimerRunEngelle.Interval = 1000;
                TimerRunEngelle.Start();
            }

           


        }


        private void MesajGöster_Tick(object sender, EventArgs e)
        {

            sistemsaati = DateTime.Now.ToShortTimeString();
            if (sistemsaati == MesajGoster.belirlenenzaman)
            {
                if (MesajGoster.tür == 1)
                {
                    MessageBox.Show(MesajGoster.mesajiçerigi.TrimEnd(), "" + MesajGoster.baslik.TrimEnd() + "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MesajGoster.tür == 2)
                {
                    MessageBox.Show(MesajGoster.mesajiçerigi.TrimEnd(), "" + MesajGoster.baslik.TrimEnd() + "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MesajGoster.tür == 3)
                {
                    MessageBox.Show(MesajGoster.mesajiçerigi.TrimEnd(), "" + MesajGoster.baslik.TrimEnd() + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MesajGöster.Stop();
            }
        }
        private void TimerBilgisayariKapat_Tick(object sender, EventArgs e)
        {


            sistemsaati = DateTime.Now.ToShortTimeString();

            if (sistemsaati == BilgisayariKapat.belirlenenzaman)
            {

                TimerBilgisayariKapat.Stop();
                try
                {

                    Process.Start("cmd.exe", "/C shutdown -f");
                    TimerBilgisayariKapat.Stop();
                }
                catch
                {

                    Process.Start("cmd.exe", "/C shutdown -f");
                    TimerBilgisayariKapat.Stop();
                }
            }



        }
        private void YenidenBaslat_Tick(object sender, EventArgs e)
        {
            if (sistemsaati == Reboot.belirlenenzaman)
            {
                try
                {

                    Process.Start("cmd.exe", "/C shutdown -r");
                }
                catch
                {

                }
            }
            else
            {

            }
        }
        private void TimerAnlikZaman_Tick(object sender, EventArgs e)
        {

            anlikzamantimelabel.Text = DateTime.Now.ToLongTimeString();

        }
        private void İnternetiKes_Tick(object sender, EventArgs e)
        {
            if (sistemsaati == NetKes.belirlenenzaman)
            {
                try
                {
                    Process.Start("ipconfig", "/release");
                }
                catch
                {
                    Process.Start("cmd.exe", "/C ipconfig/release");
                }
            }
        }
        //
        //


        private void anlikzamantimelabel_Click(object sender, EventArgs e)
        {
            if (anlikzamantimelabel.Text == "Bilgi Alınıyor ....")
            {
                MessageBox.Show("Bilgi alınamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                anlikzamantimelabel.Text = DateTime.Today.ToShortTimeString();
                anlikzamantimelabel.Text = "Bilgi Alınıyor ....";
            }
        }
        private void Gizle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void KapatmaEngeli_Tick(object sender, EventArgs e)
        {
            Process[] taskmgrs = Process.GetProcessesByName("Taskmgr");

            if (taskmgrs.Length > 0)
            {
                foreach (Process p in taskmgrs)
                {
                    p.Kill();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void TimerBelirlenenZamandanSonra_Tick(object sender, EventArgs e)
        {
            if (sistemsaati == UygulamaEngelle.belirlenenzaman)
            {
                Process[] apps = Process.GetProcessesByName(UygulamaEngelle.uygulamaadi.TrimEnd());
                if (apps.Length > 0)
                {
                    foreach (Process aa in apps)
                    {
                        aa.Kill();
                    }
                }
            }
        }

        private void TimerBelirlenenZamanaKadar_Tick(object sender, EventArgs e)
        {
            if (sistemsaati != UygulamaEngelle.belirlenenzaman)
            {
                Process[] app = Process.GetProcessesByName(UygulamaEngelle.uygulamaadi.TrimEnd());
                if (app.Length > 0)
                {
                    foreach (Process a in app)
                    {
                        a.Kill();
                    }
                }
            }
        }
        private void UygulamaOyunBaslat_Tick(object sender, EventArgs e)
        {
            if (UygulamaOyunBaslatForm.belirlenenzaman == sistemsaati)
            {
                Process.Start("cmd.exe", "/C" + UygulamaOyunBaslatForm.uygulamaadi);
                UygulamaOyunBaslat.Stop();
            }
        }

        private void UygulamaOyunBaslatTusu_MouseEnter(object sender, EventArgs e)
        {
            UygulamaOyunBaslatTusu.BackColor = Color.SkyBlue;
        }

        private void UygulamaOyunBaslatTusu_MouseLeave(object sender, EventArgs e)
        {
            UygulamaOyunBaslatTusu.BackColor = Color.Azure;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void GösterBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (YöneticiSifreKutusu.Text == KullaniciBilgileri.Default.KullaniciSifre)
                {
                    label1.Text = "Tamamdır";                   
                    AyarlarPanel.Visible = false;
                }
                else
                {
                    label1.Text = "Sifreniz gecersiz";
                }
            }
            catch
            {
                if(YöneticiSifreKutusu.Text=="")
                {
                    label1.Text = "Bir sifre girmelisiniz";
                }
            }
        }

        private void YöneticiSifreKutusu_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Sifreniz ile giris yapiniz";
        }

        private void NedirBuButton_Click(object sender, EventArgs e)
        {
            Yardim.nedirbu = 1;
            Yardim yr = new Yardim();
            yr.göstermecombo.Visible = false;
            yr.Show();
            
        }

        private void BaskaBirUygulamaKullanimi_CheckedChanged(object sender)
        {
            MessageBox.Show("Bu işlemi durdurmak için, tekrar bu bölümden ilgili ayarın işaretini kaldırınız ve ayarlari kaydetmeyi unutmayiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AyarlarPanelTamamTusu.Text = "Ayarları Kaydet";
        }
        private void GörevYöneticisiEngelleCombo_CheckedChanged(object sender)
        {
            AyarlarPanelTamamTusu.Text = "Ayarları Kaydet";
        }

        private void RunEngelleCombo_CheckedChanged(object sender)
        {
            AyarlarPanelTamamTusu.Text = "Ayarları Kaydet";
        }

        private void CmdEngelleCombo_CheckedChanged(object sender)
        {
            AyarlarPanelTamamTusu.Text = "Ayarları Kaydet";
        }

        private void UygulamaKapatilirkenSifreİsteCombo_CheckedChanged(object sender)
        {
            AyarlarPanelTamamTusu.Text = "Ayarları Kaydet";
        }

        private void BaslangicdaCalissinCombo_CheckedChanged(object sender)
        {
            AyarlarPanelTamamTusu.Text = "Ayarları Kaydet";
        }

        
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        public void BaskaBirUygulamaKullaniminiEngelle()
        {
            RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            if (objRegistryKey.GetValue("DisableTaskMgr") == null)
                objRegistryKey.SetValue("DisableTaskMgr", "1");
            else
                objRegistryKey.DeleteValue("DisableTaskMgr");
            objRegistryKey.Close();
        }

        private void TimerBaskaBirUygulamaKullanimi_Tick(object sender, EventArgs e)
        {
            SetForegroundWindow(this.Handle);
        }

        private void AyarlarPanelTamamTusu_Click(object sender, EventArgs e)
        {
            if(RunEngelleCombo.Checked==true)
            {
                Settings1.Default.RunEngellensinmi = 1;
                TimerRunEngelle.Interval = 1000;
                TimerRunEngelle.Start();
            }
            if(GörevYöneticisiEngelleCombo.Checked==true)
            {
                Settings1.Default.GörevYöneticisiEngellensinmi = 1;
                TimerGörevYöneticisiEngelle.Interval = 1000;
                TimerGörevYöneticisiEngelle.Start();
            }
            if (BaskaBirUygulamaKullanimiCombo.Checked==true)
            {
                TimerBaskaBirUygulamaKullanimi.Start();
            }
            if(CmdEngelleCombo.Checked==true)
            {
                Settings1.Default.CmdEngellensinmi = 1;
                TimerCmdEngelle.Interval = 1000;
                TimerCmdEngelle.Start();
            }
            ///////////////////////////////////////////
            if (CmdEngelleCombo.Checked == false)
            {
                TimerCmdEngelle.Stop();
                Settings1.Default.CmdEngellensinmi =0;
            }
            if (RunEngelleCombo.Checked == false)
            {
                TimerRunEngelle.Stop();
                Settings1.Default.RunEngellensinmi = 0;
            }
            if (BaskaBirUygulamaKullanimiCombo.Checked == false)
            {
                TimerBaskaBirUygulamaKullanimi.Stop();
            }
            if (GörevYöneticisiEngelleCombo.Checked == false)
            {
                Settings1.Default.GörevYöneticisiEngellensinmi = 0;
                TimerGörevYöneticisiEngelle.Stop();
            }
            AyarlarPanel.Visible = true;
            YöneticiSifreKutusu.Text = "";
        }

        private void TimerCmdEngelle_Tick(object sender, EventArgs e)
        {
            Process[] cemede = Process.GetProcessesByName("Cmd");
            if (cemede.Length > 0)
            {
                foreach (Process c in cemede)
                {
                    c.Kill();
                }
            }
        }

        private void TimerRunEngelle_Tick(object sender, EventArgs e)
        {

            Process[] run = Process.GetProcessesByName("Run");
            if (run.Length > 0)
            {
                foreach (Process r in run)
                {
                    r.Kill();
                }
            }
        }

        private void UygulamaOyunBaslatTusu_Click(object sender, EventArgs e)
        {
            UygulamaOyunBaslatForm sams = new UygulamaOyunBaslatForm();
            sams.Show();
        }

        private void oyunengelletusu_Click(object sender, EventArgs e)
        {
            UygulamaEngelle engelle = new UygulamaEngelle();
            engelle.Show();
        }

        private void ZamanlıOlarakBilgisayariKapatBTN_Click(object sender, EventArgs e)
        {
            BilgisayariKapat kapat = new BilgisayariKapat();
            kapat.Show();
        }

        private void BilgisayariYenidenBaslatTusu_Click(object sender, EventArgs e)
        {
            Reboot newstart = new Reboot();
            newstart.Show();
        }

        private void İnternetiYenileTusu_Click(object sender, EventArgs e)
        {

        }

        private void InternetiKesTusu_Click(object sender, EventArgs e)
        {
            NetKes netikes = new NetKes();
            netikes.Show();

        }
        private void MesajGösterTusu_Click(object sender, EventArgs e)
        {
            MesajGoster msj = new MesajGoster();
            msj.Show();
        }
        public static int regeditengelle,vivaldiengelle, firefoxengelle, chromeengelle, msconfigengelle, maxhtonengelle, safariengelle, iengelle;


        // MENÜ
        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Uygulama kapatilir ise devam eden islemler iptal edilecektir.Uygulama kapatılsın mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru)
            {
                if (UygulamaKapatilirkenSifreİsteCombo.Checked == true)
                {
                    KapatmaEngeli ka = new KapatmaEngeli();
                    ka.Show();
                }
                else
                {
                    Application.Exit();
                }
            }

        }
        
        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yardim.nedirbu = 3;
            Yardim helps = new Yardim();
            helps.Show();
        }

        private void güncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uygulamaTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kontrol kt = new Kontrol();
            kt.Show();
        }

        private void islemListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslemListesi run = new IslemListesi();
            run.Show();
        }

        private void yenidenBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Uygulama yeniden başlatılır ise devam eden islemler iptal edilecektir.Yeniden baslatılsın mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes==soru)
            {
                Application.Restart();
            }
            
        }

        public static int oturumukapat = 0;
        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Oturum kapatilir ise devam eden islemler iptal edilecektir.Devam etmek istiyor musunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru)
            {
                
                    oturumukapat = 1;
                    KapatmaEngeli ka = new KapatmaEngeli();
                    ka.Show();
                
            }
        }

        // MENÜ

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public static int bilgideger = 0;



        private void HizliEngelleTusu_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show(HizliEngelleCheckBox.Text + " uygulamasini engellemek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru)
            {
                try
                {
                    if (HizliEngelleCheckBox.Text == "Regedit")
                    {
                        TimerCmdEngelle.Interval = 1000;
                        TimerCmdEngelle.Start();
                        HizliEngelleTusu.Text = "İslem Tamam";

                    }
                    if (HizliEngelleCheckBox.Text == "CMD")
                    {
                        TimerCmdEngelle.Interval = 1000;
                        TimerCmdEngelle.Start();
                        HizliEngelleTusu.Text = "İslem Tamam";

                    }
                    if (HizliEngelleCheckBox.Text == "Vivaldi")
                    {
                        vivaldiengelle = 1;
                        TimerHizliEngelle.Interval = 1000;
                        TimerHizliEngelle.Start();
                        HizliEngelleTusu.Text = "İslem Tamam";
                    }
                    if (HizliEngelleCheckBox.Text == "Firefox")
                    {
                        firefoxengelle = 1;
                        TimerHizliEngelle.Interval = 1000;
                        TimerHizliEngelle.Start();
                        HizliEngelleTusu.Text = "İslem Tamam";
                    }
                    if (HizliEngelleCheckBox.Text == "Chrome")
                    {
                        chromeengelle = 1;
                        TimerHizliEngelle.Interval = 1000;
                        TimerHizliEngelle.Start();
                        HizliEngelleTusu.Text = "İslem Tamam";
                    }
                    if (HizliEngelleCheckBox.Text == "Safari")
                    {
                        safariengelle = 1;
                        TimerHizliEngelle.Interval = 1000;
                        TimerHizliEngelle.Start();
                        HizliEngelleTusu.Text = "İslem Tamam";
                    }
                    if (HizliEngelleCheckBox.Text == "Msconfig")
                    {
                        msconfigengelle = 1;
                        TimerHizliEngelle.Interval = 1000;
                        TimerHizliEngelle.Start();
                        HizliEngelleTusu.Text = "İslem Tamam";
                    }
                    if (HizliEngelleCheckBox.Text == "Maxhton")
                    {
                        maxhtonengelle = 1;
                        TimerHizliEngelle.Interval = 1000;
                        TimerHizliEngelle.Start();
                        HizliEngelleTusu.Text = "İslem Tamam";
                    }
                    if (HizliEngelleCheckBox.Text == "Internet Explorer")
                    {
                        iengelle = 1;
                        TimerHizliEngelle.Interval = 1000;
                        TimerHizliEngelle.Start();
                        HizliEngelleTusu.Text = "İslem Tamam";
                    }
                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata + " hatası nedeni ile devam edemiyoruz", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void TimerHizliEngelle_Tick(object sender, EventArgs e)
        {
            if (regeditengelle == 1)
            {
                Process[] regedit = Process.GetProcessesByName("regedit");
                if (regedit.Length > 0)
                {
                    foreach (Process v in regedit)
                    {
                        v.Kill();
                    }
                }
            }

            if (vivaldiengelle==1)
            {
                Process[] vivaldi = Process.GetProcessesByName("vivaldi");
                if(vivaldi.Length>0)
                {
                    foreach(Process v in vivaldi)
                    {
                        v.Kill();
                    }
                }
            }
            if(firefoxengelle==1)
            {
                Process[] firefox = Process.GetProcessesByName("firefox");
                if (firefox.Length > 0)
                {
                    foreach (Process v in firefox)
                    {
                        v.Kill();
                    }
                }
            }
            if (chromeengelle == 1)
            {
                Process[] chrome = Process.GetProcessesByName("chrome");
                if (chrome.Length > 0)
                {
                    foreach (Process v in chrome)
                    {
                        v.Kill();
                    }
                }
            }
            if (msconfigengelle == 1)
            {

            }
            if (maxhtonengelle == 1)
            {

            }
            if (safariengelle == 1)
            {

            }
            if (iengelle == 1)
            {

            }
        }

        private void HizliEngelleCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HizliEngelleTusu.Enabled = true;
            HizliEngelleTusu.Text = "Engelle";

        }
    }
    }


