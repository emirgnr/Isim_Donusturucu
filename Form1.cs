using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_uygula_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;

            Random rastgele_ad = new Random();
            
            
            rastgele_ad.Next(ad.Length);

            int[] sayilar = new int[] { };

            for (int i = 0; i < ad.Length; i++)
            {
                sayilar[i] = rastgele_ad.Next(ad.Length);
            }


            for (int i = 0; i < 1; i++)
            {
                listBox1.Items.Add(ad[sayilar[i]]);
            }
            

            
            /*
            int sayi_ad = rastgele_ad.Next(ad.Length);
            label7.Text = sayi_ad.ToString();

            for (int i = 0; i < 1; i++)
            {
                listBox1.Items.Add(ad[sayi_ad]);
            }
            */
            

            Random rastgele_soyad = new Random();

            int sayi_soyad = rastgele_soyad.Next(soyad.Length);
            label9.Text = sayi_soyad.ToString();
        }
    }
}
