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
            if (güvenlikcevabiTXT.Text == KullaniciBilgileri.Default.GizliCevap)
            {
                try
                {
                    MessageBox.Show("Şifreniz :" + KullaniciBilgileri.Default.KullaniciSifre + "");
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Böyle bir güvenlik cevabı bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Böyle bir güvenlik cevabı bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
