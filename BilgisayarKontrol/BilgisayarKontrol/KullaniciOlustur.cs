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
                            KullaniciBilgileri.Default.KullaniciAdi = KullaniciAdiTXT.Text;
                            KullaniciBilgileri.Default.KullaniciSifre = SifreTXT.Text;
                            KullaniciBilgileri.Default.GizliCevap = GizliCevapTXT.Text;
                            KullaniciBilgileri.Default.KullaniciVarmi = 1;
                            KullaniciBilgileri.Default.Save();
                            
                            MessageBox.Show("Kullanici olusturuldu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
