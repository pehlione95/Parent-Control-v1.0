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
    public partial class UygulamaOyunBaslatForm : Form
    {
        public UygulamaOyunBaslatForm()
        {
            InitializeComponent();
        }
        public static string uygulamaadi,belirlenenzaman;
        private void UygulamaOyunBaslat_Load(object sender, EventArgs e)
        {
         
        }

        private void TamamTusu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult soru1 = MessageBox.Show("Bu işlemi onaylıyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == soru1)
                {
                   
                    belirlenenzaman = dateTimePicker1.Value.ToLongTimeString();
                    uygulamaadi = UygulamaAdiTXT.Text;
                    AnaEkran an = new AnaEkran();
                    an.UygulamaOyunBaslat.Interval = 1000;
                    an.UygulamaOyunBaslat.Start();
                    Basarili success = new Basarili();
                    success.Show();
                    this.Hide();
                    
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Programı yeniden başlatınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(hata.ToString());
            }
        }

        private void DosyaSec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dosya.Title = "samet";
                dosya.Filter = "Sadece .exe uzantılı dosyalar|*.exe";
                dosya.RestoreDirectory = true;
                dosya.CheckFileExists = false;
                if (dosya.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = dosya.FileName;
                    UygulamaAdiTXT.Text = '"' + DosyaYolu + '"';
                    string uygulamadi = dosya.SafeFileName;
                    uygulamaadi = uygulamadi.Split('.')[0];

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Dosya görüntülemede bir problem oluştu. Programı yeniden başlatınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(hata.ToString());
            }
        }


    }
}
