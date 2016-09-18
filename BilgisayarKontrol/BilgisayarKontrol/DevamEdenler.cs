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
    public partial class DevamEdenler : Form
    {
        public DevamEdenler()
        {
            InitializeComponent();
        }

        private void mesajgosterTXT_Click(object sender, EventArgs e)
        {
            if(mesajgosterTXT.Text == "" && internetkapatTXT.Text ==""&& internetyenidenTXT.Text==""&& sistemkapatTXT.Text==""&&mesajgosterTXT.Text =="")
            {
                MessageBox.Show("Zamanlanmış işlem bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
