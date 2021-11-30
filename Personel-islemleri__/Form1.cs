using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_islemleri__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            comboBox5.Items.Add("yönetim");
            comboBox5.Items.Add("işçi");
            comboBox5.Items.Add("sekreter");
            //
            comboBox6.Items.Add("İstanbul");
            comboBox6.Items.Add("ankara");
            comboBox6.Items.Add("sivas");

            //işe başlama tarihi
            comboBox1.Items.Add("1 Ocak 1999");
            comboBox1.Items.Add("6 Kasım 2000");
            comboBox1.Items.Add("14 Aralık 2019");

            //dogum tarihi
            comboBox2.Items.Add("3 Aralık 1980");
            comboBox2.Items.Add("16 Ekim 1981");
            comboBox2.Items.Add("9 Mart 1982");

            for (int i = 0; i <= 100; i++)
            {
                comboBox3.Items.Add(i);
            }
            for (int i = 0; i <= 100; i++)
            {
                comboBox4.Items.Add(i);
            }
            
        }
        string tc, ad, soyad, birim, isebaslama, dogumyeri, dogumtarihi;

        private void button3_Click(object sender, EventArgs e)
        {
            int taz = yil * 7000;
            if (tazminathakki == true)
            {
                label14.Text = "tazminat hakkiniz " + taz + " ve 5 yılı doldurduğunuz için tazminatınızı alabilirsiniz";
            }
            else
            {
                label14.Text = "tazminat hakkiniz " + taz + " fakat 5 yılı doldurmadığınız için tazminatınızı alamazsınız";
            }
        }

        bool tazminathakki = false;

        //listboxta kullanılacaklar
        string isebaslama2, dogumtarihi2;


        int sonuç = 0;
        int yil;

        private void button2_Click(object sender, EventArgs e)
        {
            
            int sabitmaas = 4000,satilanev=0,kiralananev=0;
            satilanev = int.Parse(comboBox3.Text);
            kiralananev = int.Parse(comboBox4.Text);
            sonuç = sabitmaas + (satilanev * 500) + (kiralananev * 250);
            label10.Text = sonuç.ToString();
        }

        

        

        private void button4_Click(object sender, EventArgs e)
        {
            tazminathakki = false;
            button3.Enabled = true;
            tc = textBox4.Text;
            int sayi = tc.Length;
            if (sayi != 11)
            {
                Application.Exit();
            }
            else
            {
                ad = textBox5.Text;
                soyad = textBox6.Text;
                birim = comboBox5.Text;
                isebaslama = comboBox1.Text;
                dogumyeri = comboBox6.Text;
                dogumtarihi = comboBox2.Text;

                if (comboBox1.Text == "1 Ocak 1999")
                {
                    isebaslama2 = "1.1.1999";
                    tazminathakki = true;
                    yil = 22;
                }
                else if (comboBox1.Text == "6 Kasım 2000")
                {
                    isebaslama2 = "6.11.2000";
                    tazminathakki = true;
                    yil = 21;
                }
                else
                {
                    isebaslama2 = "14.12.2019";
                    yil = 2;
                }

                //

                if (comboBox2.Text == "3 Aralık 1980")
                {
                    dogumtarihi2 = "3.12.1980";
                }
                else if (comboBox2.Text == "16 Ekim 1981")
                {
                    dogumtarihi2 = "16.10.1981";
                }
                else
                {
                    dogumtarihi2 = "9.3.1982";
                }
                listBox1.Items.Add(tc + " " + ad + " " + soyad + " " + birim + " " + isebaslama2 + " " + dogumyeri + " " + dogumtarihi2);
            }
            
        }
    }
}
