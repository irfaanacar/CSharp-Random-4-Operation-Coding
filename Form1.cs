using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele4islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd=new Random();
        int puan = 0;
        int kalanzaman = 30;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "SONRAKİ";
            timer1.Start();
            int sayi1, sayi2, islem,cevap;
            textBox1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            textBox1.Enabled = true;
            sayi1 = Convert.ToInt32(label1.Text); 
            sayi2 = Convert.ToInt32(label3.Text);
            cevap=Convert.ToInt32(label4.Text);
            sayi1 = rd.Next(0, 51);
            label1.Text = sayi1.ToString();
            sayi2 = rd.Next(0, 51);
            label3.Text = sayi2.ToString();
            islem = rd.Next(1,5);
            label2.Text = islem.ToString();
            if(islem == 1)
            {
                label2.Text = "+";
                cevap = sayi1 + sayi2;
                label4.Text = cevap.ToString();
            }
            if(islem == 2)
            {
                label2.Text = "-";

                cevap = sayi1 - sayi2;
                label4.Text = cevap.ToString();

            }
            if (islem == 3)
            {
                label2.Text = "*";
                cevap = sayi1 * sayi2;
                label4.Text = cevap.ToString();

            }
            if (islem == 4)
            {
                label2.Text = "/";
                cevap = sayi1 / sayi2;
                label4.Text = cevap.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = false;
            if (textBox1.Text == label4.Text)
            {
                puan = puan + 10;
                label6.Text=puan.ToString();
            }
            else
            {
                puan -= 10;
                label6.Text=puan.ToString();
            }
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "30";
            kalanzaman = 30;
            button1.Enabled = true;
            label1.Text = "0";
            label2.Text = "";
            label3.Text = "0";
            puan = 0;
            label6.Text = "0";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            button2.Enabled=false;
            button3.Enabled= false;
            textBox1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanzaman--;
            label8.Text = kalanzaman.ToString();
            if (label8.Text == "0")
            {
                
                timer1.Stop();
                MessageBox.Show("Tebrikler." + label6.Text + " " + "puan alarak oyunu bitirdiniz");
                button2.Enabled = false;
                button3.Enabled = true;
                textBox1.Enabled = false;
            }
        }
    }
}
