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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        DateTime EndOfTime;
        private void button1_Click(object sender, EventArgs e)
        {

            EndOfTime = DateTime.Now.AddMinutes(10);
            Timer timer1 =new Timer() { Interval=500,Enabled=true};
            timer1.Tick+=new EventHandler(timer1_Tick);
            timer1_Tick(null, null);
            button1.Enabled = false;

        }
        void timer1_Tick(object sender,EventArgs e)
        {
            TimeSpan ts = EndOfTime.Subtract(DateTime.Now);
            label2.Text = ts.ToString();
            if (ts.TotalMilliseconds < 0)
            {
                ((Timer)sender).Enabled=false;
                MessageBox.Show("Następuje zamknięcie programu","Koniec czasu",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Environment.Exit(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brawo zdania w czasie");
            this.Close();
        }
    }
}
