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
                iptalettusu.Visible = false;
            }
            if (islemyapildi == 1)
            {
                iptalettusu.Visible = true;
            }

        }





        private void tamam_Click(object sender, EventArgs e)
        {
            belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
            DialogResult soru = MessageBox.Show("Bilgisayar " + belirlenenzaman + " aralığında kapatılsın mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == soru)
            {
                try
                {
                    AnaEkran f1 = new AnaEkran();
                    f1.TimerBilgisayariKapat.Interval = 10000;
                    f1.TimerBilgisayariKapat.Start();
                    iptalettusu.Visible = true;
                    islemyapildi = 1;
                    this.Hide();
                    Basarili success = new Basarili();
                    success.Show();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata oluştu :" + hata + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult soru2 = MessageBox.Show("Tekrar denemek istermisiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult.Yes == soru)
                    {
                        AnaEkran f1 = new AnaEkran();
                        f1.TimerBilgisayariKapat.Interval = 10000;
                        f1.TimerBilgisayariKapat.Start();
                        iptalettusu.Enabled = true;
                        islemyapildi = 1;
                        this.Hide();
                        Basarili success = new Basarili();
                        success.Show();

                    }
                    else
                    {
                        MessageBox.Show("İşlem tamamlanamıyor.Sistem saatinizi kontrol ettikden sonra programı yeniden başlatınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void kapattusu_Click(object sender, EventArgs e)
        {
            islemyapildi = 0;
            AnaEkran f1 = new AnaEkran();
            f1.TimerBilgisayariKapat.Stop();
            MessageBox.Show("Zamanlanan görev iptal edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            iptalettusu.Visible = false;
        }
    }
}
