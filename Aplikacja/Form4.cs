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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n = 0;
            float m = 0;
            if (float.TryParse(textBox1.Text,out n) && float.TryParse(textBox2.Text, out m)) 
            {
                float l = n + m;
                textBox1.Text=l.ToString();

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
                float l = n / m;
                textBox1.Text = l.ToString();

            }
            else
            {
                MessageBox.Show("Błędne dane");
            }
        }
    }
}
