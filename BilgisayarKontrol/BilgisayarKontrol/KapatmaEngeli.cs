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
    public partial class KapatmaEngeli : Form
    {
        public static string okunansifre = "samet";
        public KapatmaEngeli()
        {
            InitializeComponent();
        }

        private void KapatmaEngeli_Load(object sender, EventArgs e)
        {
            BringToFront();

        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TamamTusu_Click(object sender, EventArgs e)
        {
            try
            {
                if (sifreTXT.Text != "")
                {
                    if (sifreTXT.Text == Ayarlar.Default.KullaniciSifre)
                    {                
                     
                            Application.Exit();
                        
                    }
                    else
                    {
                        label2.Text = "Böyle bir sifre yok";
                    }
                }
                else
                {
                    label2.Text = "Eksik sifre";
                }
            }
            catch
            {

            }
        }

        private void sifreTXT_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "Yönetici sifresini yaziniz";
        }
    }
}
