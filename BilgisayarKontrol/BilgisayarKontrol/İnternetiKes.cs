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
     
        }

        private void TamamTusu_Click(object sender, EventArgs e)
        {
            belirlenenzaman = dateTimePicker1.Value.ToLongTimeString();
            DialogResult soru = MessageBox.Show("İnternet bağlantısı " + belirlenenzaman + " aralığında kesilsin mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == soru)
            {
                try
                {
                    belirlenenzaman = dateTimePicker1.Value.ToLongTimeString();
                    AnaEkran f1 = new AnaEkran();
                    f1.İnternetiKes.Interval = 10000;
                    f1.İnternetiKes.Start();
                    islemyapildi = 1;
                    this.Hide();
                    Basarili success = new Basarili();
                    success.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir hata oluştu.Tekrar deneyiniz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

            }
        }
    }
}
