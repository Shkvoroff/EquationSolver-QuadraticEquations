using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d=b*b-4*a*c;

            if (a == 0 && b == 0 && c == 0)
            {
                MessageBox.Show("Все 3 значения равны нулю. Невозможно найти корни", "Ошибка!");
            }

            else if (a == 0)
            {
                MessageBox.Show("Первый коэффицент не может равняться нулю (a ≠ 0). Невозможно найти корни", "Ошибка!");
            }

            else
            {
                if (d < 0)
                {
                    textBox7.Text = "";
                    textBox7.Text=  a+"x^2"+ " + " + b + "x" + " + " + c +" = 0";
                    textBox4.Text += d.ToString();
                    textBox5.Text ="Нету";
                    textBox6.Text ="Нету";
                    MessageBox.Show("Дискриминант меньше нуля (D<0). Корней нет", "Ответ:");
                }
                if (d == 0)
                {
                    double x = (-b / (2 * a));
                    textBox7.Text = "";
                    textBox7.Text = a + "x^2" + " + " + b + "x" + " + " + c +" = 0";
                    textBox4.Text += d.ToString();
                    textBox5.Text += x.ToString();
                    textBox6.Text += x.ToString();
                    MessageBox.Show("Дискриминант равен нулю (D=0). Корень равен " + x + ".", "Ответ:");
                }
                if (d > 0)
                {
                    double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                    textBox7.Text = "";
                    textBox7.Text = a + "x^2" + " + " + b + "x" + " + " + c +" = 0";
                    textBox4.Text += d.ToString();
                    textBox5.Text += x1.ToString();
                    textBox6.Text += x2.ToString();
                    MessageBox.Show("Дискриминант равен " + d + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".", "Ответ:");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox3.Text = "0";
            textBox2.Text = "0";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "ax2 + bx + c = 0";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
