using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

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
            
                
                KapatmaEngeli.Interval = 1000;
                KapatmaEngeli.Start();
                TimerAnlikZaman.Interval = 500;
                TimerAnlikZaman.Start();
                try
                {

                    anlikzamantimelabel.Text = DateTime.Now.ToLongTimeString();
                }
                catch
                {
                    MessageBox.Show("Sistem saatinizden, anlık olarak bilgi alınamadığı için program kullanılamaz.Sistem saatinizi ve Anti - Virüs programınızı kontrol ediniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Enabled = false;
                }
            
            
        }
       
    
        private void MesajGöster_Tick(object sender, EventArgs e)
            {
            
            sistemsaati = DateTime.Now.ToShortTimeString();
            if(sistemsaati==MesajGoster.belirlenenzaman)
            {
                if (MesajGoster.tür == 1)
                {
                    MessageBox.Show(MesajGoster.mesajiçerigi.TrimEnd(),""+MesajGoster.baslik.TrimEnd()+"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MesajGoster.tür == 2)
                {
                    MessageBox.Show(MesajGoster.mesajiçerigi.TrimEnd(), ""+MesajGoster.baslik.TrimEnd()+"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MesajGoster.tür == 3)
                {
                    MessageBox.Show(MesajGoster.mesajiçerigi.TrimEnd(), ""+MesajGoster.baslik.TrimEnd()+"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MesajGöster.Stop();
            }
        }
        private void TimerBilgisayariKapat_Tick(object sender, EventArgs e)
        {
            
            
            sistemsaati = DateTime.Now.ToShortTimeString();

            if(sistemsaati==BilgisayariKapat.belirlenenzaman)
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
            if(sistemsaati==NetKes.belirlenenzaman)
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

        private void ZamanlıOlarakBilgisayariKapatBT_Click(object sender, EventArgs e)
        {
            BilgisayariKapat kapat = new BilgisayariKapat();
            kapat.Show();
        }
        private void İnternetiKesTusu_Click(object sender, EventArgs e)
        {
            NetKes netikes = new NetKes();
            netikes.Show();
        }

        private void MesajGösterTusu_Click(object sender, EventArgs e)
        {
            MesajGoster msj = new MesajGoster();
            msj.Show();
        }
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
        private void gizletusu_Click(object sender, EventArgs e)
        {

            this.Hide();
            
        }

        private void BilgisayariYenidenBaslatTusu_Click(object sender, EventArgs e)
        {
            Reboot newstart = new Reboot();
            newstart.Show();
        }

        private void kontrolpicture_Click(object sender, EventArgs e)
        {
            Kontrol kt = new Kontrol();
            kt.Show();
        }

        private void Gizle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void AnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void AnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
            Process[] cemede = Process.GetProcessesByName("Cmd");
            if(cemede.Length>0)
            {
                foreach(Process c in cemede)
                {
                    c.Kill();
                }
            }
            Process[] run = Process.GetProcessesByName("Run");
            if(run.Length>0)
            {
                foreach(Process r in run)
                {
                    r.Kill();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void oyunengelletusu_Click(object sender, EventArgs e)
        {
            UygulamaEngelle engelle = new UygulamaEngelle();
            engelle.Show();
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
            if(sistemsaati!=UygulamaEngelle.belirlenenzaman)
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

        private void ZamanlıOlarakBilgisayariKapatBT_MouseEnter(object sender, EventArgs e)
        {
            ZamanlıOlarakBilgisayariKapatBT.BackColor = Color.SkyBlue;
        }

        private void ZamanlıOlarakBilgisayariKapatBT_MouseLeave(object sender, EventArgs e)
        {
            ZamanlıOlarakBilgisayariKapatBT.BackColor = Color.Azure;
        }

        private void İnternetiYenileTusu_MouseEnter(object sender, EventArgs e)
        {
            İnternetiYenileTusu.BackColor = Color.SkyBlue;
        }

        private void İnternetiYenileTusu_MouseLeave(object sender, EventArgs e)
        {
            İnternetiYenileTusu.BackColor = Color.Azure;
        }

        private void İnternetiKesTusu_MouseEnter(object sender, EventArgs e)
        {
            İnternetiKesTusu.BackColor = Color.SkyBlue;
        }

        private void İnternetiKesTusu_MouseLeave(object sender, EventArgs e)
        {
            İnternetiKesTusu.BackColor = Color.Azure;
        }

        private void oyunengelletusu_MouseEnter(object sender, EventArgs e)
        {
            oyunengelletusu.BackColor = Color.SkyBlue;
        }

        private void oyunengelletusu_MouseLeave(object sender, EventArgs e)
        {
            oyunengelletusu.BackColor = Color.Azure;
        }

        private void BilgisayariYenidenBaslatTusu_MouseEnter(object sender, EventArgs e)
        {
            BilgisayariYenidenBaslatTusu.BackColor = Color.SkyBlue;
        }

        private void BilgisayariYenidenBaslatTusu_MouseLeave(object sender, EventArgs e)
        {
            BilgisayariYenidenBaslatTusu.BackColor = Color.Azure;
        }

        private void MesajGösterTusu_MouseEnter(object sender, EventArgs e)
        {
            MesajGösterTusu.BackColor = Color.SkyBlue;
        }

        private void MesajGösterTusu_MouseLeave(object sender, EventArgs e)
        {
            MesajGösterTusu.BackColor = Color.Azure;
        }

        private void gizletusu_MouseEnter(object sender, EventArgs e)
        {
            gizletusu.BackColor = Color.SkyBlue;
        }

        private void gizletusu_MouseLeave(object sender, EventArgs e)
        {
            gizletusu.BackColor = Color.Azure;
        }


        private void cikistusu_MouseEnter(object sender, EventArgs e)
        {
            cikistusu.BackColor = Color.SkyBlue;
        }

        private void cikistusu_MouseLeave(object sender, EventArgs e)
        {
            cikistusu.BackColor = Color.Azure;
        }
        private void cikistusu_Click(object sender, EventArgs e)
        {
            KapatmaEngeli ka = new KapatmaEngeli();
            ka.Show();
        }

        private void DevamEdenlerTusu_Click(object sender, EventArgs e)
        {
            DevamEdenler dv = new DevamEdenler();
            dv.Show();
        }

        private void hakkindatusu_Click(object sender, EventArgs e)
        {
            Hakkinda sam = new Hakkinda();
            sam.Show();
        }

        private void UygulamaOyunBaslatTusu_Click(object sender, EventArgs e)
        {
            UygulamaOyunBaslat sams = new UygulamaOyunBaslat();
            sams.Show();
        }
    }
    }


