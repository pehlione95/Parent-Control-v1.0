﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilgisayarKontrol
{
    public partial class Yardim : Form
    {
        public Yardim()
        {
            InitializeComponent();
        }
        public static int nedirbu = 0;
        public static int ilkacilis = 0;
        
        private void iTalk_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void Yardim_Load(object sender, EventArgs e)
        {
                   
            
                if (nedirbu == 1)
                {
                    richTextBox1.Text = "Bu alanda değişiklik yapabilmek için,yönetici olduğunuzu doğrulamamız gerekmektedir";
                //nedirbu = 0;
                }
                if (nedirbu == 0)

                    richTextBox1.Text = "Kategoriye ayrılmış olan bölümlerden zamana bağlı olarak işlem yapabilirsiniz.Bir işlem ister o an ister belirtilen zamanda yapılması için ayarlanabilir.Programın kullanımı sırasında Görev Yöneticisi ' nin çalışması engellenecektir. Programın kapatılması içinde güvenlik nedeni ile ilk girişde belirlenen şifreye gereksinim duyulmaktadır.Bu ayarları, ayarlar bölümünden değiştirebilirsiniz.";
                 }
        int a = 5;

        private void TamamTusu_Click(object sender, EventArgs e)
        {
            if (göstermecombo.Checked == true)
            {
                Settings1.Default.Yardim = 1;
                this.Hide();
            }
            else
            {
                nedirbu = 0;
                this.Hide();
            }
        }
    }
    }

