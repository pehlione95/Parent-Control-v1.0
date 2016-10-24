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
    public partial class MesajGoster : Form
    {
        public MesajGoster()
        {
            InitializeComponent();
        }
        public static string belirlenenzaman,mesajiçerigi,baslik;
        public static byte islem = 0,tür=0;

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void TamamTusu_Click(object sender, EventArgs e)
        {
            if (mesajTXT.Text.Length < 1 || baslikTXT.Text.Length < 1 || comboBox1.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
                    DialogResult soru = MessageBox.Show("Mesaj " + belirlenenzaman + " aralığında gösterilsin mi ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult.Yes == soru)
                    {
                        belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
                        baslik = baslikTXT.Text.TrimEnd();
                        mesajiçerigi = mesajTXT.Text.TrimEnd();
                        AnaEkran ana = new AnaEkran();
                        ana.MesajGöster.Interval = 10000;
                        ana.MesajGöster.Start();
                        islem = 1;
                        this.Hide();
                        Basarili success = new Basarili();
                        success.Show();
                    }
                }
                catch (Exception hata)

                {
                    MessageBox.Show("Hata kaynağı :" + hata + "", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error); ;
                    DialogResult soru = MessageBox.Show("Tekrar denemek istermisiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult.Yes == soru)
                    {
                        belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
                        baslik = baslikTXT.Text.TrimEnd();
                        mesajiçerigi = mesajTXT.Text.TrimEnd();
                        AnaEkran ana = new AnaEkran();
                        ana.MesajGöster.Interval = 10000;
                        ana.MesajGöster.Start();
                        islem = 1;
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Hata")
            {
                tür = 1;
            }
            else if(comboBox1.Text=="Uyarı")
            {
                tür = 2;
            }
            else if(comboBox1.Text=="Bilgilendirme")
            {
                tür = 3;
            }
        }

        private void MesajGoster_Load(object sender, EventArgs e)
        {
            
        }
    }
}
