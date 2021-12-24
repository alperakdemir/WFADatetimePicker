using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFADatetimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hesapla();
        }
        DateTime dogumTarihi;

        private void Hesapla()
        {
            dogumTarihi = dtpDogumTarihi.Value;
            lblYasiniz.Text = "Yaşınız: " + YasHesapla(dogumTarihi.Year);
            lblYasadiginGun.Text = "Yaşadığın gün: " + GunHesapla(dogumTarihi);
        }

        private string GunHesapla(DateTime dogumTarihi)
        {
            TimeSpan gecenSure = DateTime.Now - dogumTarihi;
            int toplamGun = (int)gecenSure.TotalDays;
            return toplamGun.ToString();
        }

        private string YasHesapla(int year)
        {
            return (DateTime.Now.Year - year).ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //1-Yaşını hesaplayınız.
            Hesapla();
                   
                                  


        }
    }
}
