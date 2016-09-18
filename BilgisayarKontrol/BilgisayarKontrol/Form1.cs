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

        private void Form1_Load(object sender, EventArgs e)
        {
            TimerAnlikZaman.Interval = 900;
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
        private void gizletusu_Click(object sender, EventArgs e)
        {

        }
        private void bilgisayarikapat()
        {
            try
            {

                Process.Start("ipconfig","/release");
            }
            catch
            {
               
                Process.Start("ipconfig","/release");
                Process.Start("cmd.exe", "/C ipconfig/release");
            }


        }
        private void MesajGöster_Tick(object sender, EventArgs e)
            {
            
            string sistemsaati = DateTime.Now.ToShortTimeString();
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
            
            
            string sistemsaati = DateTime.Now.ToShortTimeString();

            if(sistemsaati==BilgisayariKapat.belirlenenzaman)
            {
                bilgisayarikapat();
                TimerBilgisayariKapat.Stop();
            }
            
            
                      
        }
        private void TimerAnlikZaman_Tick(object sender, EventArgs e)
        {

            anlikzamantimelabel.Text = DateTime.Now.ToLongTimeString();
            
        }
        private void ZamanlıOlarakBilgisayariKapatBT_Click(object sender, EventArgs e)
        {
            BilgisayariKapat kapat = new BilgisayariKapat();
            kapat.Show();
        }
        private void hakkindatusu_Click(object sender, EventArgs e)
        {
            Hakkinda sam = new Hakkinda();
            sam.Show();
            
        }
           private void İnternetiKesTusu_Click(object sender, EventArgs e)
        {
            İnternetiKes netikes = new İnternetiKes();
            netikes.Show();
        }
        private void DevamEdenlerTusu_Click(object sender, EventArgs e)
        {
            DevamEdenler dv = new DevamEdenler();
            dv.Show();
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
                MessageBox.Show("Bu bilgi sistem saatinizden, anlık olarak alınmaktadır.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     
    }
}
