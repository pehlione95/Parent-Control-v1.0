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


        private void tamamtusu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(sifreTXT.Text) == Settings1.Default.Sifre)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Sifre yanlis. Doğru sifre girilene kadar uygulama, güvenlik nedeni ile kapatılamaz", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
            }
            catch
            {
                MessageBox.Show("Sifre yanlis. Doğru sifre girilene kadar uygulama, güvenlik nedeni ile kapatılamaz", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void kapattusu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
