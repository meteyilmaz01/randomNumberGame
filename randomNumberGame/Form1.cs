using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace randomNumberGame
{
    public partial class Form1 : Form
    {
        int deneme;
        int sayi;
        int cnt=1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Başlayabilirsiniz ";
            Random rdn = new Random();
            sayi = rdn.Next(0, 100);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cnt <= 5)
            {
                deneme = Int32.Parse(textBox1.Text);
                if (deneme < sayi) label1.Text = " Daha büyük bir sayı gir ";
                if (deneme > sayi) label1.Text = " Daha küçük bir sayı gir ";
                if (deneme == sayi) label1.Text = " Kazandınız ";
                cnt++;
            }
            else
            {
                label1.Text = "Kaybettiniz tekrardan başlayınız sayı = "+ sayi; 
                
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
