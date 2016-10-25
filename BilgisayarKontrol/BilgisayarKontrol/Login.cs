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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void GirisTusu_Click(object sender, EventArgs e)
        {
            if(KullaniciAdiTXT.Text == Ayarlar.Default.KullaniciAdi && sifreTXT.Text == Ayarlar.Default.KullaniciSifre)
            {
                AnaEkran an = new AnaEkran();
                an.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(Ayarlar.Default.KullaniciAdi=="1234")
            {
                MessageBox.Show("ss");
            }
            
        }
    }
}
