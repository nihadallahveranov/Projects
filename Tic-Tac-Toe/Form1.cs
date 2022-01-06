using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        short count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void turn()
        {
            if (count % 2 == 0)
            {
                label1.Text = "Turn is: x";
            }
            else
            {
                label1.Text = "Turn is: o";
            }
        }
        private void check()
        {
            if ((button1.Text=="o" && button2.Text=="o" && button3.Text == "o") || 
                (button1.Text=="o" && button5.Text=="o" && button9.Text=="o") || 
                (button1.Text == "o" && button4.Text == "o" && button7.Text == "o") || 
                (button7.Text == "o" && button8.Text == "o" && button9.Text == "o") ||
                (button4.Text == "o" && button5.Text == "o" && button6.Text == "o") ||
                (button2.Text == "o" && button5.Text == "o" && button8.Text == "o") ||
                (button3.Text == "o" && button6.Text == "o" && button9.Text == "o") ||
                (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
                )
            {
                MessageBox.Show("o won", "Tic-Tac-Toe");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if ((button1.Text == "x" && button2.Text == "x" && button3.Text == "x") ||
                (button1.Text == "x" && button5.Text == "x" && button9.Text == "x") ||
                (button1.Text == "x" && button4.Text == "x" && button7.Text == "x") ||
                (button7.Text == "x" && button8.Text == "x" && button9.Text == "x") ||
                (button4.Text == "x" && button5.Text == "x" && button6.Text == "x") ||
                (button2.Text == "x" && button5.Text == "x" && button8.Text == "x") ||
                (button3.Text == "x" && button6.Text == "x" && button9.Text == "x") ||
                (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
                )
            {
                MessageBox.Show("x won", "Tic-Tac-Toe");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            turn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button1.Text = "x";
            }
            else
            {
                button1.Text = "o";
            }
            button1.Enabled = false;
            count++;
            turn();
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button2.Text = "x";
            }
            else
            {
                button2.Text = "o";
            }
            button2.Enabled = false;
            count++;
            turn();
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button3.Text = "x";
            }
            else
            {
                button3.Text = "o";
            }
            button3.Enabled = false;
            count++;
            turn();
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button4.Text = "x";
            }
            else
            {
                button4.Text = "o";
            }
            button4.Enabled = false;
            count++;
            turn();
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button5.Text = "x";
            }
            else
            {
                button5.Text = "o";
            }
            button5.Enabled = false;
            count++;
            turn();
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button6.Text = "x";
            }
            else
            {
                button6.Text = "o";
            }
            button6.Enabled = false;
            count++;
            turn();
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button7.Text = "x";
            }
            else
            {
                button7.Text = "o";
            }
            button7.Enabled = false;
            count++;
            turn();
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button8.Text = "x";
            }
            else
            {
                button8.Text = "o";
            }
            button8.Enabled = false;
            count++;
            turn();
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button9.Text = "x";
            }
            else
            {
                button9.Text = "o";
            }
            button9.Enabled = false;
            count++;
            turn();
            check();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "Turn is: x";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            count = 0;
        }
    }
}
