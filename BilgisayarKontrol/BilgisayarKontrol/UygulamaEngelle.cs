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
    public partial class UygulamaEngelle : Form
    {
        public UygulamaEngelle()
        {
            InitializeComponent();
        }
        public static string uygulamaadi,zamandansonrauygulama,zamanakadaruygulama;
        public static string belirlenenzaman;
        public static int zamankadarislem=0, zamandansonra;
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dosya.Filter = "Exe uzantılı oyun/uygulama|*.exe";
                dosya.RestoreDirectory = true;
                dosya.CheckFileExists = false;
                dosya.Title = "Oyun veya uygulama seçiniz";

                if (dosya.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = dosya.FileName;
                    uygulamadiTXT.Text = DosyaYolu;
                    string uygulamadi = dosya.SafeFileName;
                    uygulamaadi = uygulamadi.Split('.')[0];

                }
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu. Programı yeniden başlattıktan sonra tekrar deneyin", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tamam_Click(object sender, EventArgs e)
        {
            if(belirlenenzamanakadarradio.Checked==true&&uygulamadiTXT.Text.Length>1)
            {
                zamanakadaruygulama += uygulamaadi;
                AnaEkran an = new AnaEkran();
                an.TimerBelirlenenZamanaKadar.Interval = 2000;
                an.TimerBelirlenenZamanaKadar.Start();
                zamankadarislem = 1;
                Basarili success = new Basarili();
                success.Show();
                this.Hide();


            }
            if(belirlenenzamandansonraradio.Checked==true&&uygulamadiTXT.Text.Length>1)
            {

                zamandansonrauygulama += uygulamaadi;
                    AnaEkran an = new AnaEkran();
                    an.TimerBelirlenenZamandanSonra.Interval = 2000;
                    an.TimerBelirlenenZamandanSonra.Start();
                    Basarili success = new Basarili();
                    zamandansonra = 1;
                    success.Show();
                    this.Hide();
                
            }
            else if(uygulamadiTXT.Text.Length< 1)
            {
                MessageBox.Show("Uygulama seçilmedi","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
          
        }

        private void belirlenenzamanakadarradio_CheckedChanged(object sender, EventArgs e)
        {
            if(belirlenenzamanakadarradio.Checked==true)
            {
                belirlenenzamandansonraradio.Checked = false;
            }
        }

        private void belirlenenzamandansonraradio_CheckedChanged(object sender, EventArgs e)
        {
            if(belirlenenzamandansonraradio.Checked==true)
            {
                belirlenenzamanakadarradio.Checked = false;
            }
        }

        private void iptalettusu_Click(object sender, EventArgs e)
        {
            if(zamandansonra==1)
            {
                DialogResult soru = MessageBox.Show("Belirlenen zamandan sonra "+zamandansonrauygulama.TrimEnd()+" kapatma aktif. İptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == soru)
                {
                    AnaEkran an = new AnaEkran();
                    an.TimerBelirlenenZamandanSonra.Stop();
                }
            }
            if(zamankadarislem==1)
            {
                DialogResult sooru = MessageBox.Show("Belirlenen zamana kadar "+zamanakadaruygulama.TrimEnd()+" kapatma aktif. İptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == sooru)
                {
                    AnaEkran an = new AnaEkran();
                    an.TimerBelirlenenZamanaKadar.Stop();
                }
            }
            this.Hide();
        }

        private void UygulamaEngelle_Load(object sender, EventArgs e)
        {
            bilgibir.Visible = false;
            bilgiiki.Visible = false;
            if(zamandansonra ==1)
            {
                bilgibir.Visible = true;
                bilgibir.Text = "Belirlenen zamandan sonra engelleme aktif";
                iptalettusu.Visible = true;
            }
            if(zamankadarislem==1)
            {
                bilgiiki.Visible = true;
                bilgiiki.Text = "Belirlenen zamana kadar engelleme aktif";
                iptalettusu.Visible = true;
            }
            belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
        }
    }
}
