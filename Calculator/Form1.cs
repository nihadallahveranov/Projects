using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator_form1 : Form
    {
        double x, y;
        char operation;
        public Calculator_form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc_txt.Text = "0";
            button1.Text = "AC";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
           if (calc_txt.Text == "0")
            {
                calc_txt.Text = "";
            } 
            calc_txt.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
            if (calc_txt.Text == "0")
            {
                calc_txt.Text = "";
            }
            calc_txt.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
            if (calc_txt.Text == "0")
            {
                calc_txt.Text = "";
            }
            calc_txt.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
            if (calc_txt.Text == "0")
            {
                calc_txt.Text = "";
            }
            calc_txt.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
            if (calc_txt.Text == "0")
            {
                calc_txt.Text = "";
            }
            calc_txt.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
            if (calc_txt.Text == "0")
            {
                calc_txt.Text = "";
            }
            calc_txt.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
            if (calc_txt.Text == "0")
            {
                calc_txt.Text = "";
            }
            calc_txt.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
            if (calc_txt.Text == "0")
            {
                calc_txt.Text = "";
            }
            calc_txt.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
            if (calc_txt.Text == "0")
            {
                calc_txt.Text = "";
            }
            calc_txt.Text += "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button1.Text = "C";
            if (calc_txt.Text == "0")
            {
                calc_txt.Text += "";
            }
            else
            {
                calc_txt.Text += "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)   // / - divide
        {
            MyFunction('/');
        }

        private void button16_Click(object sender, EventArgs e)   // +++++++
        {
            
            MyFunction('+');
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string str = calc_txt.Text,str2="";
            int size = str.Length,num=1000000000;
            for (int i = 1; i < size; i++)
            {
                if (str[i] == operation)
                {
                    num = i;
                }
                if (i > num)
                {
                    str2 += str[i];
                }
            }
            if (str2 != "")
            {
                y = Convert.ToDouble(str2);
            }
            if (operation == '+')
            {
                calc_txt.Text = Convert.ToString(x + y);
            }
            else if (operation == '-')
            {
                calc_txt.Text = Convert.ToString(x - y);
            }
            else if (operation == '*')
            {
                calc_txt.Text = Convert.ToString(x * y);
            }
            else if (operation == '/')
            {
                calc_txt.Text = Convert.ToString(x / y);
            }
        }






        private void button12_Click(object sender, EventArgs e)  // ---------
        {
            MyFunction('-');

        }

        private void button2_Click(object sender, EventArgs e)     // SQRT
        {
            string str = calc_txt.Text, str2 = "", str3 = "";
            int size = str.Length, num = 0, num2 = 0;
            try
            {
                if (str[size - 1] != '-' && str[size - 1] != '*' && str[size - 1] != '+' && str[size - 1] != '/')
                {
                    for (int i = 1; i < size; i++)
                    {
                        if (str[i] == '-' || str[i] == '+' || str[i] == '/' || str[i] == '*')
                        {
                            operation = str[i];
                            num = i;
                            break;
                        }
                    }
                    if (num > 0)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (i < num)
                            {
                                str2 += str[i];
                            }
                            else if (i > num)
                            {
                                str3 += str[i];
                            }
                        }
                        if (operation == '+')
                        {
                            x = Convert.ToDouble(str2) + Convert.ToDouble(str3);
                        }
                        else if (operation == '-')
                        {
                            x = Convert.ToDouble(str2) - Convert.ToDouble(str3);
                        }
                        else if (operation == '*')
                        {
                            x = Convert.ToDouble(str2) * Convert.ToDouble(str3);
                        }
                        else if (operation == '/')
                        {
                            x = Convert.ToDouble(str2) / Convert.ToDouble(str3);
                        }
                        calc_txt.Text = Convert.ToString(Math.Sqrt(x));
                    }
                    else if (num == 0)
                    {
                        if (str[size - 1] != '-' && str[size - 1] != '*' && str[size - 1] != '/' && str[size - 1] != '+')
                        {
                            x = Convert.ToDouble(str);
                            calc_txt.Text = Convert.ToString(Math.Sqrt(x));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void button3_Click(object sender, EventArgs e)    // POW
        {
            string str = calc_txt.Text, str2 = "", str3 = "";
            int size = str.Length, num = 0, num2 = 0;
            try
            {
                if (str[size - 1] != '*' && str[size - 1] != '+' && str[size - 1] != '/' && str[size - 1] != '-')
                {
                    for (int i = 1; i < size; i++)
                    {
                        if (str[i] == '-' || str[i] == '+' || str[i] == '/' || str[i] == '*')
                        {
                            operation = str[i];
                            num = i;
                            break;
                        }
                    }
                    if (num > 0)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (i < num)
                            {
                                str2 += str[i];
                            }
                            else if (i > num)
                            {
                                str3 += str[i];
                            }
                        }
                        if (operation == '+')
                        {
                            x = Convert.ToDouble(str2) + Convert.ToDouble(str3);
                        }
                        else if (operation == '-')
                        {
                            x = Convert.ToDouble(str2) - Convert.ToDouble(str3);
                        }
                        else if (operation == '*')
                        {
                            x = Convert.ToDouble(str2) * Convert.ToDouble(str3);
                        }
                        else if (operation == '/')
                        {
                            x = Convert.ToDouble(str2) / Convert.ToDouble(str3);
                        }
                        calc_txt.Text = Convert.ToString(Math.Pow(x,2));
                    }
                    else if (num == 0)
                    {
                        if (str[size - 1] != '*' && str[size - 1] != '/' && str[size - 1] != '+' && str[size - 1] != '-')
                        {
                            x = Convert.ToDouble(str);
                            calc_txt.Text = Convert.ToString(Math.Pow(x,2));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void button8_Click(object sender, EventArgs e)       // *************
        {
            MyFunction('*');
        }




        private void button18_Click(object sender, EventArgs e)
        {
            string str = calc_txt.Text;
            int size = str.Length;
            if (str[size - 1]!= '.')
            {
                calc_txt.Text += ".";
            }
            button1.Text = "C";
        }







        private void MyFunction(char btn)
        {
            try
            {
                string str = calc_txt.Text, str2 = "", str3 = "";
                int size = str.Length, num = 0, num2 = 0;
                if (str[size - 1] != '*' && str[size - 1] != '/' && str[size - 1] != '+' && str[size - 1] != '-')
                {
                    if (calc_txt.Text == "0")
                    {
                        calc_txt.Text = "";
                    }
                    for (int i = 1; i < size; i++)
                    {
                        if (str[i] == '-' || str[i] == '+' || str[i] == '/' || str[i] == '*')
                        {
                            operation = str[i];
                            num = i;
                            break;
                        }
                    }
                    if (num > 0)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (i < num)
                            {
                                str2 += str[i];
                            }
                            else if (i > num)
                            {
                                str3 += str[i];
                            }
                        }
                        if (operation == '+')
                        {
                            x = Convert.ToDouble(str2) + Convert.ToDouble(str3);
                        }
                        else if (operation == '-')
                        {
                            x = Convert.ToDouble(str2) - Convert.ToDouble(str3);
                        }
                        else if (operation == '*')
                        {
                            x = Convert.ToDouble(str2) * Convert.ToDouble(str3);
                        }
                        else if (operation == '/')
                        {
                            x = Convert.ToDouble(str2) / Convert.ToDouble(str3);
                        }
                        calc_txt.Text = Convert.ToString(x);
                        calc_txt.Text += btn;
                        operation = btn;
                    }
                    else if (num == 0)
                    {
                        if (str[size - 1] != btn)
                        {
                            calc_txt.Text += btn;
                            x = Convert.ToDouble(str);
                            operation = btn;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
