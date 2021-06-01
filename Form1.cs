using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        double wynik;
        double a;
        double b;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            //wynik = Convert.ToDouble(textBox2.Text);
           
            if (radioButton1.Checked == true)
            {
                textBox3.Font = new Font(textBox3.Font.FontFamily, 10, FontStyle.Bold);
            }
            
            if(listBox1.SelectedItem.ToString() == "Opcja 1")
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                wynik = a + b;
                textBox3.Text = (Convert.ToString("Suma" + textBox1.Text + "+" + textBox2.Text + "=" + wynik));
            }
            else if(listBox1.SelectedItem.ToString() == ("Opcja 2"))
            {
                this.Close();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            wynik = a - b;
            textBox3.Text = (Convert.ToString("Różnica" + textBox1.Text + "-" + textBox2.Text + "=" + wynik));
            if (radioButton1.Checked == true)
            {
                textBox3.Font = new Font(textBox3.Font.FontFamily, 10, FontStyle.Bold);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            wynik = a * b;
            textBox3.Text = (Convert.ToString("Iloczyn" + textBox1.Text + "*" + textBox2.Text + "=" + wynik));
            if (radioButton1.Checked == true)
            {
                textBox3.Font = new Font(textBox3.Font.FontFamily, 10, FontStyle.Bold);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            if (b == 0)
            {
                textBox3.Text = "Nie można dzielić przez 0!";
                MessageBox.Show("Nie można dzielić przez 0!");
            }
            else
            {

                wynik = a / b;
                textBox3.Text = (Convert.ToString("Iloraz" + textBox1.Text + "/" + textBox2.Text + "=" + wynik));
            }
            if (radioButton1.Checked == true)
            {
                textBox3.Font = new Font(textBox3.Font.FontFamily, 10, FontStyle.Bold);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
    }
}
