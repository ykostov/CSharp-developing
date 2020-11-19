using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms_Ex._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, S = 0;

            a = int.Parse(textBox1.Text);
            
            if (a < 200 && a > 0)
            {
                label4.Visible = false;
                b = a;
                while (b <= 200)
                {
                    S = S + b;
                    b = b + 1;
                }
                label2.Text = "" + S;
            }
            else
            {
                label4.Visible = true;
            }

        }
    }
}
