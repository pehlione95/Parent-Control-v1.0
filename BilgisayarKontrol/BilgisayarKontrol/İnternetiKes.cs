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
    public partial class NetKes : Form
    {
        public NetKes()
        {
            InitializeComponent();
        }
        public static string belirlenenzaman;
        public static int islemyapildi = 0;
        
        private void İnternetiKes_Load(object sender, EventArgs e)
        {
            if(islemyapildi==0)
            {
                
                iptalettusu.Enabled = false;

            }
            else if(islemyapildi==1)
            {
               
                iptalettusu.Enabled = true;
            }
        }


        private void tamamtusu_Click(object sender, EventArgs e)
        {
            belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
            DialogResult soru = MessageBox.Show("İnternet bağlantısı " + belirlenenzaman + " aralığında kesilsin mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == soru)
            {
                try
                {
                    AnaEkran f1 = new AnaEkran();
                    f1.İnternetiKes.Interval = 10000;
                    f1.TimerBilgisayariKapat.Start();
                    iptalettusu.Enabled = false;
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
                        f1.İnternetiKes.Interval = 10000;
                        f1.TimerBilgisayariKapat.Start();
                        iptalettusu.Enabled = false;
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
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaEkran an = new AnaEkran();
            an.İnternetiKes.Stop();
        }
    }
}
