using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BilgisayarKontrol
{
    public partial class BilgisayariKapat : Form
    {
        public BilgisayariKapat()
        {
            InitializeComponent();
        }
        public static string belirlenenzaman;
        public static int islemyapildi = 0;
        private void BilgisayariKapat_Load(object sender, EventArgs e)
        {
            if (islemyapildi == 0)
            {
                iptalettusu.Enabled = false;
            }
            if (islemyapildi == 1)
            {
                iptalettusu.Enabled = true;
            }

        }

        private void tamamtusu_Click(object sender, EventArgs e)
        {
            belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
            DialogResult soru = MessageBox.Show("Bilgisayar " + belirlenenzaman + " aralığında kapatılsın mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == soru)
            {
                AnaEkran f1 = new AnaEkran();
                f1.TimerBilgisayariKapat.Interval = 10000;
                f1.TimerBilgisayariKapat.Start();
                iptalettusu.Enabled = false;
                islemyapildi = 1;
                this.Hide();
            }
            else
            {

            }
        }

        private void iptalettusu_Click(object sender, EventArgs e)
        {
            islemyapildi = 0;
            AnaEkran f1 = new AnaEkran();
            f1.TimerBilgisayariKapat.Stop();
            MessageBox.Show("Zamanlanan görev iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            iptalettusu.Enabled = false;
        }
    }
}
