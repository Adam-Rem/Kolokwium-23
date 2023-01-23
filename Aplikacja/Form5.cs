using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n = 0;
            float m = 0;
            if (float.TryParse(textBox1.Text, out n) && float.TryParse(textBox2.Text, out m))
            {
                float l = n + m;
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float n = 0;
            float m = 0;
            if (float.TryParse(textBox1.Text, out n) && float.TryParse(textBox2.Text, out m))
            {
                float l = n - m;
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float n = 0;
            float m = 0;
            if (float.TryParse(textBox1.Text, out n) && float.TryParse(textBox2.Text, out m))
            {
                float l = n * m;
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float n = 0;
            float m = 0;
            if (float.TryParse(textBox1.Text, out n) && float.TryParse(textBox2.Text, out m))
            {
                float l = n + m;
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            float n = 0;
            float m = 0;
            if (float.TryParse(textBox1.Text, out n) && float.TryParse(textBox2.Text, out m))
            {
                float l = n - m;
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            float n = 0;
            float m = 0;
            if (float.TryParse(textBox1.Text, out n) && float.TryParse(textBox2.Text, out m))
            {
                float l = n * m;
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            float n = 0;
            float m = 0;
            if (float.TryParse(textBox1.Text, out n) && float.TryParse(textBox2.Text, out m))
            {
                float l = n / m;
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n = 0;
            double m = 0;
            if (double.TryParse(textBox1.Text, out n) && double.TryParse(textBox2.Text, out m))
            {
                double l =Math.Pow(n,m);
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double n = 0;
            double m = 0;
            if (double.TryParse(textBox1.Text, out n) && double.TryParse(textBox2.Text, out m))
            {
                double l = Math.Pow(n, 1/m);
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double n = 0;
            
            if (double.TryParse(textBox1.Text, out n))
            {
                double l = Math.Sin(n);
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }
    }
}
