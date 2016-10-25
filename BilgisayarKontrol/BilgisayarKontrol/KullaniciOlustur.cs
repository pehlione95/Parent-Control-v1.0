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
    public partial class KullaniciOlustur : Form
    {
        public KullaniciOlustur()
        {
            InitializeComponent();
        }
        
       


        private void FirstGiris_Load(object sender, EventArgs e)
        {
            
        }

 

        private void TamamTusu_Click(object sender, EventArgs e)
        {
            if(KullaniciAdiTXT.Text !="" || KullaniciAdiTXT.Text.Length > 1 || SifreTXT.Text != "" || SifreTXT.Text.Length > 1)
            {
                if(SifreTXT.Text == SifreTekrariTXT.Text)
                {
                    if(GizliCevapTXT.Text.Length >1)
                    {
                        try
                        {
                            Ayarlar.Default.KullaniciAdi = KullaniciAdiTXT.Text;
                            Ayarlar.Default.KullaniciSifre = SifreTXT.Text;
                            Ayarlar.Default.GizliCevap = GizliCevapTXT.Text;
                            Ayarlar.Default.KullaniciVarmi = 1;
                            Ayarlar.Default.Save();
                            Ayarlar.Default.Upgrade();
                            
                            MessageBox.Show("Kullanici olusturuldu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        catch
                        {
                            MessageBox.Show("Malesef bir hata ile karşılaşıldı.Üyelik oluşturulamadı.Programı yeniden başlatınız", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gizli cevap çok kısa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Boş veya kısa bırakmayınız", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
