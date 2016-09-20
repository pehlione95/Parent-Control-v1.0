using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilgisayarKontrol
{
    public partial class DevamEdenler : Form
    {
        public DevamEdenler()
        {
            InitializeComponent();
        }

        
        private void DevamEdenler_Load(object sender, EventArgs e)
        {
            SistemKapatmaİptal.Enabled = false;
            YenidenBaslatİptal.Enabled = false;
            MesajGöstermeİptal.Enabled = false;
            İnternetKapatmaİptal.Enabled = false;
            ZamanakadarİPTAL.Enabled = false;
            ZamandansonraİPTAL.Enabled = false;
            try
            {
                sistemkapatTXT.Text = BilgisayariKapat.belirlenenzaman;
                sistemyenidenTXT.Text = Reboot.belirlenenzaman;
                mesajgosterTXT.Text = MesajGoster.belirlenenzaman;
                internetkapatTXT.Text = NetKes.belirlenenzaman;
                zamanakadarTXT.Text += " "+UygulamaEngelle.zamanakadaruygulama;
                zamandansonraTXT.Text += " "+UygulamaEngelle.zamandansonrauygulama;
                
            }
            catch
            {

            }

            if(sistemkapatTXT.Text.Length>1)
            {
                SistemKapatmaİptal.Enabled = true;
            }
            if(sistemyenidenTXT.Text.Length>1)
            {
                YenidenBaslatİptal.Enabled = true;
            }
            if(mesajgosterTXT.Text.Length>1)
            {
                MesajGöstermeİptal.Enabled = true;
            }
            if(internetkapatTXT.Text.Length>1)
            {
                İnternetKapatmaİptal.Enabled = true;
            }
            if(zamanakadarTXT.Text.Length>1)
            {
                ZamanakadarİPTAL.Enabled = true;
            }
            if(zamandansonraTXT.Text.Length>1)
            {
                ZamandansonraİPTAL.Enabled = true;
            }
        }
        private void SistemKapatmaİptal_Click(object sender, EventArgs e)
        {
            
            DialogResult soru = MessageBox.Show("Zamanlanmış görevi iptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru)
            {
                try
                {

                    BilgisayariKapat.islemyapildi = 0;
                    AnaEkran f1 = new AnaEkran();
                    f1.TimerBilgisayariKapat.Stop();
                    MessageBox.Show("Zamanlanan görev iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sistemkapatTXT.Clear();

                }


                catch
                {
                    MessageBox.Show("İslem iptal edilemedi.Bu islemi ilgili bölümden deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BilgisayariKapat bg = new BilgisayariKapat();
                    bg.Show();
                }
            }
        }

        private void İnternetKapatmaİptal_Click(object sender, EventArgs e)
        {

            DialogResult soru = MessageBox.Show("Zamanlanmış görevi iptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru)
            {
                try
                {

                    NetKes.islemyapildi = 0;
                    AnaEkran f1 = new AnaEkran();
                    f1.İnternetiKes.Stop();
                    MessageBox.Show("Zamanlanan görev iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sistemkapatTXT.Clear();

                }


                catch
                {
                    MessageBox.Show("İslem iptal edilemedi.Bu islemi ilgili bölümden deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NetKes net = new NetKes();
                    net.Show();
                }
            }
        }

        private void MesajGöstermeİptal_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Zamanlanmış görevi iptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru)
            {
                try
                {

                    MesajGoster.islem = 0;
                    AnaEkran an = new AnaEkran();
                    an.MesajGöster.Stop();
                    MessageBox.Show("Zamanlanan görev iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mesajgosterTXT.Clear();

                }


                catch
                {
                    MessageBox.Show("İslem iptal edilemedi.Bu islemi ilgili bölümden deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MesajGoster msg = new MesajGoster();
                    msg.Show();
                }
            }
        }

        private void İnternetYenidenBaslatİptal_Click(object sender, EventArgs e)
        {
            
        }

        private void YenidenBaslatİptal_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Zamanlanmış görevi iptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru)
            {
                try
                {

                    Reboot.islem = 0;
                    AnaEkran f1 = new AnaEkran();
                    f1.YenidenBaslat.Stop();
                    MessageBox.Show("Zamanlanan görev iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sistemyenidenTXT.Clear();

                }


                catch
                {
                    MessageBox.Show("İslem iptal edilemedi.Bu islemi ilgili bölümden deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reboot rb = new Reboot();
                    rb.Show();
                }
            }
        }
     
        private void mesajgosterTXT_Click(object sender, EventArgs e)
        {
            if(sistemyenidenTXT.Text==""&&mesajgosterTXT.Text == "" && internetkapatTXT.Text ==""&& internetyenidenTXT.Text==""&& sistemkapatTXT.Text==""&&mesajgosterTXT.Text =="")
            {
                MessageBox.Show("Zamanlanmış işlem bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ZamandansonraİPTAL_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Zamanlanmış görevi iptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru)
            {
                try
                {

                    UygulamaEngelle.zamandansonra = 1;
                    AnaEkran an = new AnaEkran();
                    an.TimerBelirlenenZamandanSonra.Stop();
                    MessageBox.Show("Zamanlanan görev iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    zamandansonraTXT.Clear();

                }


                catch
                {
                    MessageBox.Show("İslem iptal edilemedi.Bu islemi ilgili bölümden deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UygulamaEngelle app = new UygulamaEngelle();
                    app.Show();
                }
            }
        }

        private void ZamanakadarİPTAL_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Zamanlanmış görevi iptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru)
            {
                try
                {

                    UygulamaEngelle.zamankadarislem = 1;
                    AnaEkran an = new AnaEkran();
                    an.TimerBelirlenenZamanaKadar.Stop();
                    MessageBox.Show("Zamanlanan görev iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    zamanakadarTXT.Clear();

                }


                catch
                {
                    MessageBox.Show("İslem iptal edilemedi.Bu islemi ilgili bölümden deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UygulamaEngelle app = new UygulamaEngelle();
                    app.Show();
                }
            }
        }
    }
}
