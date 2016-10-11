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
    public partial class UygulamaAcKapat : Form
    {
        public UygulamaAcKapat()
        {
            InitializeComponent();
        }
        public static string uygulamaadi, uygulamayolu, belirlenenzaman;
        public static int yapilanislem = 0, openandclose = 0;

        private void UygulamaAcKapat_Load(object sender, EventArgs e)
        {
            if(yapilanislem == 1)
            {
                iptalettusu.Visible = true;
                tamam.Enabled = false;
                this.Text = "Uygulama Aç - Kapat (Sadece 1 islem)";
                bilgilendirme.Visible = true;
            }
            else if(yapilanislem==0)
            {
                iptalettusu.Visible = false;
                tamam.Enabled = true;
                this.Text = "Uygulama Aç - Kapat";
                bilgilendirme.Visible = false;
            }
        }

        private void tamam_Click(object sender, EventArgs e)
        {
         
            if (uygulamadiTXT.Text.Length < 1 || uygulamadiTXT.Text == "")
            {
                MessageBox.Show("Bir uygulama seçiniz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (uygulamadiTXT.Text.Length > 1 && uygulamadiTXT.Text != "")
            {
                try
                {
                    belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
                    AnaEkran an = new AnaEkran();
                    if (openradio.Checked == true)
                    {
                        openandclose = 2;                        
                        an.TimerUygulamaBaslat.Interval = 10000;
                        an.TimerUygulamaBaslat.Start();
                        yapilanislem = 1;
                        
                        Basarili success = new Basarili();
                        success.Show();
                        this.Hide();
                    }
                    else if(kapatradio.Checked ==true)
                    {
                        openandclose = 1;
                        an.TimerUygulamaBaslat.Interval = 10000;
                        an.TimerUygulamaBaslat.Start();
                        yapilanislem = 1;
                        Basarili success = new Basarili();
                        success.Show();
                        this.Hide();
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata oluştu.Tekrar deneyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(hata.ToString());
                }
            }
        }



        private void openradio_CheckedChanged(object sender, EventArgs e)
        {
            if(openradio.Checked == true)
            {
                kapatradio.Checked = false;
            }
        }

        private void kapatradio_CheckedChanged(object sender, EventArgs e)
        {
            if (kapatradio.Checked == true)
            {
                openradio.Checked = false;
            }
        }

        private void iptalettusu_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("İşlemi iptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes==a)
            {
                yapilanislem = 0;
                AnaEkran an = new AnaEkran();
                an.TimerUygulamaBaslat.Stop();
                MessageBox.Show("İşlem iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosya.Title = "Dosya Seç";
            dosya.Filter = "Sadece EXE uzantılı|*.exe";
            dosya.RestoreDirectory = true;
            if(dosya.ShowDialog()==DialogResult.OK)
            {
                uygulamaadi = dosya.SafeFileName;
                uygulamayolu = dosya.FileName;
                uygulamadiTXT.Text = uygulamaadi.TrimEnd();
            }
            

        }
    }
}
