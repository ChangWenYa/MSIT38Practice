using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0125_littlegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Text =".";
            btn2.Text =".";
            btn3.Text =".";
            btn4.Text =".";
            btn5.Text =".";
            btn6.Text =".";
            btn7.Text =".";
            btn8.Text =".";
            btn9.Text =".";

            labelturn.Text ="o";
            labelwin.Text  =".";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           if(btn1.Text == ".")
            {
                if(labelturn.Text =="o")
                {
                    btn1.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    btn1.Text="x";
                    labelturn.Text="o";
                }
            }

           if(btn1.Text =="o" && btn2.Text =="o" && btn3.Text =="o")
            {
                labelwin.Text = "o";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == ".")
            {
                if (labelturn.Text =="o")
                {
                    btn2.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    btn2.Text="x";
                    labelturn.Text="x";
                }
            }
            if (btn1.Text =="o" && btn2.Text =="o" && btn3.Text =="o")
            {
                labelwin.Text = "o";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == ".")
            {
                if (labelturn.Text =="o")
                {
                    btn3.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    btn3.Text="x";
                    labelturn.Text="o";
                }
            }
            //if (btn3.Text =="o" && btn4.Text =="o" && btn5.Text =="o")
            //{
            //    labelwin.Text = "o";
            //}
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == ".")
            {
                if (labelturn.Text =="o")
                {
                    btn4.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    btn4.Text="x";
                    labelturn.Text="o";
                }
            }
           
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == ".")
            {
                if (labelturn.Text =="o")
                {
                    btn5.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    btn5.Text="x";
                    labelturn.Text="o";
                }
            }
           
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == ".")
            {
                if (labelturn.Text =="o")
                {
                    btn6.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    btn6.Text="x";
                    labelturn.Text="o";
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == ".")
            {
                if (labelturn.Text =="o")
                {
                    btn7.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    btn7.Text="x";
                    labelturn.Text="o";
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == ".")
            {
                if (labelturn.Text =="o")
                {
                    btn8.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    btn8.Text="x";
                    labelturn.Text="o";
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == ".")
            {
                if (labelturn.Text =="o")
                {
                    btn9.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    btn9.Text="x";
                    labelturn.Text="o";
                }
            }
        }
    }
}
