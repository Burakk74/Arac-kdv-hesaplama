using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23MY03001_ODEV_NO_03001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            double arac_fiyat;
            double otv_oran;
            double kdv_oran;
            double toplam_fiyat;
            double eklenen_vergi;
            Boolean keç = true;


            try
            {
            azfiyat:
                
                arac_fiyat = Convert.ToDouble(textBox1.Text);
                 
                if (arac_fiyat < 50000.0 || comboBox1.Text == "")
                {
                    if (comboBox1.Text == "")
                    {
                        
                        MessageBox.Show("Lütfen araç kategorisi seçin !");
                        keç = false;
                         

                        textBox1.Clear();
                        goto azfiyat;
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz fiyat uygun değildir ! " +
                       "(50.000 ₺ altı fiyatlar geçerli değildir)"  
                        );
                        keç = false;
                         

                        textBox1.Clear();
                        goto azfiyat;
                    }
                   
                     
                }

                keç = true;
                if(comboBox1.Text == "Otomobil")
                {
                    kdv_oran = 0.20;
                    otv_oran = 0.45;
                    otv_oran_lbl.Text = "%45";
                    kdv_oran_lbl.Text = "%20";
                }
                else if(comboBox1.Text == "Motosiklet")
                {
                    kdv_oran = 0.20;
                    otv_oran = 0.08;
                    otv_oran_lbl.Text = "%8";
                    kdv_oran_lbl.Text = "%20";
                }
                else if (comboBox1.Text == "Otobüs" || comboBox1.Text == "Midibüs" || comboBox1.Text == "Minibüs")
                {
                    kdv_oran = 0.20;
                    otv_oran = 0.01;
                    otv_oran_lbl.Text = "%1";
                    kdv_oran_lbl.Text = "%20";
                }
               
                else if(comboBox1.Text == "Hybrid")
                {
                    kdv_oran = 0.20;
                    otv_oran = 0.45;
                    otv_oran_lbl.Text = "%45";
                    kdv_oran_lbl.Text = "%20";

                }
                else if (comboBox1.Text == "Elektrik")
                {
                    kdv_oran = 0.20;
                    otv_oran = 0.10;
                    otv_oran_lbl.Text = "%10";
                    kdv_oran_lbl.Text = "%20";
                }

                else    
                {
                    kdv_oran = 0.20;
                    otv_oran = 0.10;
                    otv_oran_lbl.Text = "%10";
                    kdv_oran_lbl.Text = "%20";
                }
              
                

                double otv_tutar = (arac_fiyat * otv_oran);
                double otvli_tutar = arac_fiyat + otv_tutar;

                double kdv_tutar = otvli_tutar * kdv_oran;
                double kdvli_tutar = otvli_tutar + kdv_tutar;
                eklenen_vergi = otv_tutar + kdv_tutar;

                kdv_tutar_lbl.Text = kdv_tutar.ToString() +" ₺";
                otv_tutar_lbl.Text = otv_tutar.ToString() + " ₺";
                

                eklenen_vergi_lbl.Text = Convert.ToString(eklenen_vergi) + " ₺";

                toplam_fiyat = kdvli_tutar;
                toplam_fiyat_lbl.Text = Convert.ToString(kdvli_tutar) + " ₺";
                 
            }
            catch {
                if(keç == true)
                {
                    MessageBox.Show("Lütfen girdiğiniz değerden emin olunuz !");
                    textBox1.Clear();
                }
                

            }  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
