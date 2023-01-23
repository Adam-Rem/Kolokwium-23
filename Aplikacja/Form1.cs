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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Text == "matematyka" && haslo.Text == "matematyka")
            {
                Form2 form2 = new Form2();
                form2.Show();

            }
            if (login.Text == "filozofia" && haslo.Text == "filozofia")
            {
                Form6 form3 = new Form6();
                form3.Show();

            }
;
        }
    }
}
