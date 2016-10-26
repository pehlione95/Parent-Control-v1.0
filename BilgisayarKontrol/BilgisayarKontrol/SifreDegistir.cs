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
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void TamamTusu_Click(object sender, EventArgs e)
        {
            if(kadiTXT.Text == Ayarlar.Default.KullaniciAdi && eskipwTXT.Text == Ayarlar.Default.KullaniciSifre)
            {
                if(yenipwTXT.Text.Length > 1 || yenipwTXT.Text != "")
                {
                    Ayarlar.Default.KullaniciSifre = yenipwTXT.Text;
                    Ayarlar.Default.Save();
                    Ayarlar.Default.Upgrade();
                    Basarili success = new Basarili();
                    success.Show();
                    this.Hide();
                }
            }
            else
            {
                kadiTXT.Text = "Kullanici bilgileri yanlis";
                eskipwTXT.Text = "Kullanici bilgileri yanlis";
            }
        }
    }
}
