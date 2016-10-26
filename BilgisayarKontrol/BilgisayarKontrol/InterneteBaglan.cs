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
    public partial class InterneteBaglan : Form
    {
        public InterneteBaglan()
        {
            InitializeComponent();
        }
        public static string belirlenenzaman;
        private void InterneteBaglan_Load(object sender, EventArgs e)
        {

        }

        private void TamamTusu_Click(object sender, EventArgs e)
        {
            belirlenenzaman = dateTimePicker1.Value.ToLongTimeString();
            if (belirlenenzamanakadarnetRadio.Checked==true)
            {
                DialogResult soru = MessageBox.Show("İnternet erişimi " + belirlenenzaman + " saatine kadar kesilip, o saatden sonra tekrar açılsın mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == soru)
                {
                    belirlenenzaman = dateTimePicker1.Value.ToLongTimeString();
                    MessageBox.Show(belirlenenzaman);
                    Process.Start("ipconfig", " /release");
                    AnaEkran an = new AnaEkran();
                    an.TimerİnterneteBaglan.Interval = 1000;
                    an.TimerİnterneteBaglan.Start();
                    Basarili success = new Basarili();
                    success.Show();
                    this.Hide();
                }
            }
            if(belirlenenzamanakadarnetRadio.Checked==false)
            {
                DialogResult soru2 = MessageBox.Show("İnternet erişimi " + belirlenenzaman + " saatinden sonra açılsın mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == soru2)
                {                    
                    AnaEkran an = new AnaEkran();
                    an.TimerİnterneteBaglan.Interval = 1000;
                    an.TimerİnterneteBaglan.Start();
                    Basarili success = new Basarili();
                    success.Show();
                    this.Hide();
                }
            }

        }
    }
}
