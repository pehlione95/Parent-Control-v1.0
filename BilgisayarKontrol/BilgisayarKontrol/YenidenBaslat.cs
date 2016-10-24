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
    public partial class Reboot : Form
    {
        public Reboot()
        {
            InitializeComponent();
        }
        public static int islem = 0;
        public static string belirlenenzaman;
        
        
        private void YenidenBaslat_Load(object sender, EventArgs e)
        {
         
        }

        private void TamamTusu_Click(object sender, EventArgs e)
        {
            belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
            DialogResult soru = MessageBox.Show("Bilgisayar " + belirlenenzaman + " aralığında yeniden başlatılsın mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == soru)
            {
                try
                {
                    AnaEkran an = new AnaEkran();
                    an.YenidenBaslat.Interval = 10000;
                    an.YenidenBaslat.Start();
                    islem = 1;
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

                        AnaEkran an = new AnaEkran();
                        an.YenidenBaslat.Interval = 10000;
                        an.YenidenBaslat.Start();
                        islem = 1;
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
    }
}
    

