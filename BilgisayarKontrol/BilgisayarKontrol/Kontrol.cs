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
    public partial class Kontrol : Form
    {
        public Kontrol()
        {
            InitializeComponent();
        }
        int a = 0;
        private void Kontrol_Load(object sender, EventArgs e)
        {
            gif.Visible = false;
            progressBar1.Maximum = 100;
            progressBar1.Step = 10;
            KontrolTimer.Interval = 1000;
            
        }

        private void KontrolTimer_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            a += 10;
            if(a<40)
            {
                gif.Visible = true;
                label1.Text = "Başlatılıyor..";
                progressBar1.Value = a;

                
            }
            if(a>40 && a<progressBar1.Maximum)
            {
                
                label1.Text = "Fonksiyonlar Kontrol Ediliyor...";
                progressBar1.Value = a;
                try
                {
                    örnektimer.Interval = 1000;
                    örnektimer.Start();
                }
                catch
                {
                    gif.Visible = false;
                    label1.Text = "Hata Bulundu";
                    MessageBox.Show("Program yönetici olarak çalıştırılmalıdır.Anti - Virüs programınızdan gerekli izinleri aldığınızdan emin olunuz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KontrolTimer.Stop();
                }
            }
          
            if(a==progressBar1.Maximum)
            {
                progressBar1.Value = 100;
                label1.Text = "Program tüm fonksiyonlarını yerine getirebilir. Şimdi devam edebilirsiniz";
                KontrolTimer.Stop();
                if(progressBar1.Value==100)
                {
                    progressBar1.Value = 0;
                    gif.Visible = false;
                    button1.Visible = false;
                    tamamtusu.Text = "Devam et";
                }

            }
        }

        private void tamamtusu_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void örnektimer_Tick(object sender, EventArgs e)
        {
            string sistemsaati = DateTime.Now.ToShortTimeString();
            if(sistemsaati.Length<1)
            {
                label1.Text = "Hata Bulundu";
                MessageBox.Show("Program yönetici olarak çalıştırılmalıdır.Anti - Virüs programınızdan gerekli izinleri aldığınızdan emin olunuz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KontrolTimer.Stop();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolTimer.Start();
            
        }
    }
}
