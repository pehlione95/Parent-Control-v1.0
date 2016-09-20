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
            if (Settings1.Default.User == 1)
            {
                
            }
            else if (Settings1.Default.User == 0)
            {
                
                Sifreolustur fs = new Sifreolustur();
                fs.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings1.Default.Sifre = 0;
            Settings1.Default.User = 0;
            Settings1.Default.Save();
        }

        private void Giristusu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(sifreTXT.Text) == Settings1.Default.Sifre)
                {
                    AnaEkran an = new AnaEkran();
                    an.Show();
                    this.Hide();
                }
                else
                {
                    label1.ForeColor = Color.IndianRed;
                    label1.Text = "Böyle bir sifre bulunamadı";
                }
            }
            catch
            {
                label1.ForeColor = Color.IndianRed;
                label1.Text = "Şifre sadece sayi olabilir";
            }
        }

        private void sifreTXT_TextChanged(object sender, EventArgs e)
        {
            //label1.Text = "Kullanıcı bilgileriniz ile giriş yapınız";
            //label1.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SifremiUnuttum pw = new SifremiUnuttum();
            pw.Show();
        }
    }
}
