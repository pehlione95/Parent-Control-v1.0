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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }


        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }


        private void TamamTusu_Click(object sender, EventArgs e)
        {
            if (güvenlikcevabiTXT.Text == Ayarlar.Default.GizliCevap && kadiTXT.Text == Ayarlar.Default.KullaniciAdi)
            {
                try
                {
                    güvenlikcevabiTXT.Text = "Sifreniz : " + Ayarlar.Default.KullaniciSifre;
                    
                }
                catch
                {
                    MessageBox.Show("Bir hata oluştu", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                kadiTXT.Text = "Bilgiler doğru değil";
                güvenlikcevabiTXT.Text = "Bilgiler doğru değil";

            }
        }

    }
}
