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
    public partial class Sifreolustur : Form
    {
        public Sifreolustur()
        {
            InitializeComponent();
        }
        
       


        private void FirstGiris_Load(object sender, EventArgs e)
        {
            
        }

 
        private void sifreolusturtusu_Click(object sender, EventArgs e)
        {
            if (sifreTXT.Text == "" || sifreTXT.Text.Length < 4 || cevapTXT.Text == "")
            {
                MessageBox.Show("Uygunsuz şifre. En az 4 rakam. Örnek : 1234");
            }
            else if (sifreTXT.Text == "1234")
            {
                MessageBox.Show("Bu şifre güvenlik nedeni ile kabul edilemez.Biraz daha zor olabilir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult soru = MessageBox.Show("Şifrenizi " + sifreTXT.Text.TrimEnd() + " olarak oluşturmak istiyor musunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == soru)
                {
                    try
                    {
                        Settings1.Default.Sifre = Convert.ToDouble(sifreTXT.Text);
                        Settings1.Default.Soru = cevapTXT.Text;
                        Settings1.Default.User = 1;
                        Settings1.Default.Save();
                        MessageBox.Show("Şifreniz oluşturuldu.Bu şifre programın başlaması ve kapatılması için gereklidir.Şifreniz : " + sifreTXT.Text.TrimEnd());
                        
                        Application.Exit();

                    }
                    catch
                    {
                        MessageBox.Show("Kurallara uymamış olabilirsiniz.Kayıt islemi tamamlanamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
                else
                {

                }

            }
        }

        private void kapattusu_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Kapatmak istiyor musunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes==soru)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
