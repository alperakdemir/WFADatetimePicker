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
            lblBurc.Text = "Burcunuz: " + BurcHesapla(dogumTarihi.Month, dogumTarihi.Day);
        }

        private string BurcHesapla(int month, int day)
        {
            string burc = "";
            if ((month == 1 && day >= 21) || (month == 2 && day <= 19))//Kova => Ocak 21 - 19 Şubat
            {
                burc = "Kova";
            }
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
            {
                burc = "Balık";
            }
            else if ((month == 3 && day >=21) || (month == 4 && day <= 21))
            {
                burc = "Koç";
            }
            else if ((month == 4 && day >=21) || (month == 5 && day <= 21))
            {
                burc = "Boğa";
            }
            else if ((month == 5 && day >=22) || (month == 6 && day <= 21))
            {
                burc = "İkizler";
            }
            else if ((month == 6 && day >=22) || (month == 7 && day <= 21))
            {
                burc = "Yengeç";
            }
            else if ((month == 7 && day >= 24) || (month == 8 && day <= 23))
            {
                burc = "Aslan";
            }
            else if ((month == 8 && day >= 21) || (month == 9 && day <= 23))
            {
                burc = "Başak";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 23))
            {
                burc = "Terazi";
            }
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
            {
                burc = "Akrep";
            }
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 23))
            {
                burc = "Yay";
            }
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
            {
                burc = "Boğa";
            }
            else if ((month == 22 && day >= 12) || (month == 1 && day <= 20))
            {
                burc = "Boğa";
            }
            return burc;
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
