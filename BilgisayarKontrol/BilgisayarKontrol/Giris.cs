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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }


        private void Giris_Load(object sender, EventArgs e)
        {
            if (Ayarlar.Default.KullaniciVarmi == 1)
            {
                
            }
            if (Ayarlar.Default.KullaniciVarmi == 0)
            {
                
                KullaniciOlustur fs = new KullaniciOlustur();
                fs.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }


        private void label2_Click(object sender, EventArgs e)
        {
            
            SifremiUnuttum pw = new SifremiUnuttum();
            pw.Show();
        }

        private void GirisTusu_Click(object sender, EventArgs e)
        {
           
            try
            {
                if(KullaniciAdiTXT.Text.Length > 1 && sifreTXT.Text.Length > 1)
                {
                    string kadi = KullaniciAdiTXT.Text.TrimEnd();
                    string sifre = sifreTXT.Text.TrimEnd();
                    if(kadi == Ayarlar.Default.KullaniciAdi && sifre==Ayarlar.Default.KullaniciSifre)
                    {
                        AnaEkran main = new AnaEkran();
                        main.Show();
                    }
                    else
                    {
                        label1.Text = "Yanlıs sifre veya kullanici adi";
                    }
                    
                }
                else
                {
                    label1.Text = "Eksik bilgi";
                }
            }
            catch
            {

            }
         
        }

        private void sifreTXT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void KullaniciAdiTXT_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Kullanıcı bilgileriniz ile giriş yapınız";
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SifreDegistir pwdegistir = new SifreDegistir();
            pwdegistir.Show();
        }
    }
}
