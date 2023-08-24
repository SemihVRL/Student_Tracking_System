using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turkcell_Temel_FormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbxAdSoyad.Text != "" && tbxDurum.Text != "" && tbxOrt.Text != "" && tbxSınav1.Text != "" && tbxSınav2.Text != "" && mtbxNumara.Text != "" && cbxDers.Text != "")//textler boş değilse
            {
                ÖğrenciBilgileri.Items.Add(
                 "ADI SOYADI:  " + tbxAdSoyad.Text
                 + "  DERS ADI:  " + cbxDers.Text
                 + "  OKUL NUMARASI:  " + mtbxNumara.Text
                 + "  1.SINAV NOTU:  " + tbxSınav1.Text
                 + "  2.SINAV NOTU:  " + tbxSınav2.Text
                 + "  ORTALAMASI:  " + tbxOrt.Text
                 + "  SINIFI GEÇME DURUMU:  " + tbxDurum.Text);

                
            }
            else
            {
                MessageBox.Show("Veri olmadan kaydedilemez","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
                
              
        }

        int sayac=0;
        
        private void btnKaydet_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (tbxAdSoyad.Text != "" && tbxDurum.Text != "" && tbxOrt.Text != "" && tbxSınav1.Text != "" && tbxSınav2.Text != "" && mtbxNumara.Text != "" && cbxDers.Text != "")
                {
                    sayac++;
                    lblVeri.Text = Convert.ToString(sayac);

                }
                else
                {
                    lblVeri.Text = "Yeterli Öğrenci bilgisine ulaşılamadı";
                }
                if (ÖğrenciBilgileri.Items != null)
                {
                    tbxAdSoyad.Clear();
                    tbxOrt.Clear();
                    cbxDers.SelectedIndex = -1;//combo boxların verilerini silmek için selected index -1 yapmamız gerekiyor

                    tbxSınav1.Clear();
                    tbxSınav2.Clear();
                    tbxDurum.Clear();
                    mtbxNumara.Clear();
                }
                else
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
                

        }
        private void btnSifirlama_Click(object sender, EventArgs e)
        {
            sayac = 0;
            lblVeri.Text = Convert.ToString(sayac);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
          
            ÖğrenciBilgileri.Items.Remove(ÖğrenciBilgileri.SelectedItem);//listboxta seçilen değerlerin silinmesi
            sayac--;
            lblVeri.Text = Convert.ToString(sayac);
         
        }
        int sayi1, sayi2;
        double ort;

        string durum;

        

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToInt32(tbxSınav1.Text);
                sayi2 = Convert.ToInt32(tbxSınav2.Text);

                ort = (sayi1 + sayi2) / 2;

                tbxOrt.Text = ort.ToString();

                if (ort >= 50)
                {
                    durum = "GEÇTİ";
                }
                else
                {
                    durum = "KALDI";
                }
                tbxDurum.Text = durum;

            }
            catch 
            {
                MessageBox.Show("Bir sınav notu girmediniz:","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
    }
}
