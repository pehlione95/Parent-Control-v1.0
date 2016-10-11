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
    public partial class UygulamaOyunBaslat : Form
    {
        public UygulamaOyunBaslat()
        {
            InitializeComponent();
        }
        public static string uygulamaadi;
        private void UygulamaOyunBaslat_Load(object sender, EventArgs e)
        {
            

        }

        private void DosyaSec_Click(object sender, EventArgs e)
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
                UygulamaAdiTXT.Text = DosyaYolu;
                string uygulamadi = dosya.SafeFileName;
                uygulamaadi = uygulamadi.Split('.')[0];

            }
        }

        private void tamamtusu_Click(object sender, EventArgs e)
        {

        }

        private void iptalettusu_Click(object sender, EventArgs e)
        {

        }
    }
}
