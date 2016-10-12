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
    public partial class UygulamaOyunBaslatForm : Form
    {
        public UygulamaOyunBaslatForm()
        {
            InitializeComponent();
        }
        public static string uygulamaadi,belirlenenzaman;
        public static int islemyapildi = 0;
        private void UygulamaOyunBaslat_Load(object sender, EventArgs e)
        {
            if(islemyapildi==0)
            {
                iptalettusu.Visible = false;
            }
            if(islemyapildi==1)
            {
                iptalettusu.Visible = true;
            }

        }

        private void DosyaSec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dosya.Title = "samet";
                dosya.Filter = "Sadece .exe uzantılı dosyalar|*.exe";
                dosya.RestoreDirectory = true;
                dosya.CheckFileExists = false;
                if (dosya.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = dosya.FileName;
                    UygulamaAdiTXT.Text = '"' + DosyaYolu + '"';
                    string uygulamadi = dosya.SafeFileName;
                    uygulamaadi = uygulamadi.Split('.')[0];

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Dosya görüntülemede bir problem oluştu. Programı yeniden başlatınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(hata.ToString());
            }
        }

        private void tamamtusu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult soru1 = MessageBox.Show("Bu işlemi onaylıyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == soru1)
                {
                    if (islemyapildi == 1)
                    {
                        MessageBox.Show("Devam eden bir isleminiz bulunmaktadır. En fazla bir islem yapılabilir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    else
                    {
                        islemyapildi = 1;
                        belirlenenzaman = dateTimePicker1.Value.ToShortTimeString();
                        uygulamaadi = UygulamaAdiTXT.Text;
                        AnaEkran an = new AnaEkran();
                        an.UygulamaOyunBaslat.Interval = 2000;
                        an.UygulamaOyunBaslat.Start();
                        this.Hide();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Programı yeniden başlatınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(hata.ToString());
            }

        }

        private void iptalettusu_Click(object sender, EventArgs e)
        {
            DialogResult soru2 = MessageBox.Show("Zamanlanmış görevi iptal etmek istiyormusunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == soru2)
            {
                islemyapildi = 0;
                AnaEkran an = new AnaEkran();
                an.UygulamaOyunBaslat.Stop();
            }
            else
            {

            }
        }
    }
}
