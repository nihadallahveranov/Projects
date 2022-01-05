using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
namespace McDonalds
{
    public partial class Form1 : Form
    {
        OleDbConnection connection1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + @"\McDonalds_DataBase.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label1.Text = "M\nc\n\nD\no\nn\na\nl\nd\ns";
            panel4.Visible = false;
            button1.Location = new Point(97, 150);
            label5.Location = new Point(118, 195);
            linkLabel1.Location = new Point(245, 195);
        }

        private void user_txt_TextChanged(object sender, EventArgs e)
        {
            user_txt.ForeColor = Color.Black;  
            
        }

        private void user_txt_Click(object sender, EventArgs e)
        {
            if (button1.Text=="Sign in")
            {
                if (paswd_txt.Text == "")
                {
                    count2 = 0;
                    paswd_txt.PasswordChar = '\0';
                    paswd_txt.Text = "Password";
                    paswd_txt.ForeColor = Color.Silver;
                }
            }
            else
            {
                if (paswd_txt.Text == "")
                {
                    count2 = 0;
                    paswd_txt.PasswordChar = '\0';
                    paswd_txt.Text = "Password";
                    paswd_txt.ForeColor = Color.Silver;
                }
                if (verivfy_txt.Text == "")
                {
                    count3 = 0;
                    verivfy_txt.PasswordChar = '\0';
                    verivfy_txt.Text = "Confirm Password";
                    verivfy_txt.ForeColor = Color.Silver;
                }
            }
            if (count1 == 0)
            {
                user_txt.Clear();
                user_txt.ForeColor = Color.Black;
            }
            count1++;
        }
        byte count1 = 0;
        byte count2 = 0;
        byte count3 = 0;

        private void paswd_txt_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Sign in")
            {
                if (user_txt.Text == "")
                {
                    count1 = 0;
                    user_txt.PasswordChar = '\0';
                    user_txt.Text = "Username";
                    user_txt.ForeColor = Color.Silver;
                }
            }
            else
            {
                if (user_txt.Text == "")
                {
                    count1 = 0;
                    user_txt.PasswordChar = '\0';
                    user_txt.Text = "Username";
                    user_txt.ForeColor = Color.Silver;
                }
                if (verivfy_txt.Text == "")
                {
                    count3 = 0;
                    verivfy_txt.PasswordChar = '\0';
                    verivfy_txt.Text = "Confirm Password";
                    verivfy_txt.ForeColor = Color.Silver;
                }
            }
            if (count2 == 0)
            {
                paswd_txt.Clear();
                paswd_txt.ForeColor = Color.Black;
                paswd_txt.PasswordChar = '*';
            }
            count2++;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user_txt.Text = "Username";
            paswd_txt.Text = "Password";
            verivfy_txt.Text = "Confirm Password";
            paswd_txt.PasswordChar = '\0';
            verivfy_txt.PasswordChar = '\0';
            count1 = 0; count2 = 0; count3 = 0;
            user_txt.ForeColor = Color.Silver;
            paswd_txt.ForeColor = Color.Silver;
            verivfy_txt.ForeColor = Color.Silver;
            if (linkLabel1.Text == "Sign up")
            {
                label2.Text = "Sign up";
                panel2.Location = new Point(91, 38);
                panel3.Location = new Point(91, 94);
                panel4.Location = new Point(91, 150);
                panel4.Visible = true;
                button1.Text = "Sign up";
                button1.Location = new Point(97, 206);
                linkLabel1.Text = "Sign in";
                linkLabel1.Location = new Point(255, 250);
                label5.Text = "Have an account?";
                label5.Location = new Point(105, 250);
            }
            else
            {
                label2.Text = "Sign in";
                panel2.Location = new Point(91, 38);
                panel3.Location = new Point(91, 94);
                panel4.Visible = false;
                button1.Text = "Sign in";
                linkLabel1.Text = "Sign up";
                linkLabel1.Location = new Point(245, 195);
                button1.Location = new Point(91, 150);
                label5.Text = "Not a Member?";
                label5.Location = new Point(118, 195);
            }
        }

        private void verivfy_txt_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Sign in")
            {
                if (user_txt.Text == "")
                {
                    count1 = 0;
                    user_txt.PasswordChar = '\0';
                    user_txt.Text = "Username";
                    user_txt.ForeColor = Color.Silver;
                }
            }
            else
            {
                if (user_txt.Text == "")
                {
                    count1 = 0;
                    user_txt.PasswordChar = '\0';
                    user_txt.Text = "Username";
                    user_txt.ForeColor = Color.Silver;
                }
                if (paswd_txt.Text == "")
                {
                    count2 = 0;
                    paswd_txt.PasswordChar = '\0';
                    paswd_txt.Text = "Password";
                    paswd_txt.ForeColor = Color.Silver;
                }
            }
            if (count3 == 0)
            {
                verivfy_txt.Clear();
                verivfy_txt.ForeColor = Color.Black;
                verivfy_txt.PasswordChar = '*';
            }
            count3++;
        }
        byte excount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Sign up")
            {
                excount = 0;
                if ((paswd_txt.Text != verivfy_txt.Text) && paswd_txt.Text != "" && paswd_txt.Text != "Password" && verivfy_txt.Text != "" && verivfy_txt.Text != "Confirm Password")
                {
                    MessageBox.Show("Passwords Are Different.", "McDonalds");
                    excount++;
                }

                if (user_txt.Text == "Username" || paswd_txt.Text == "Password" || verivfy_txt.Text == "Confirm Password" ||
                        user_txt.Text == "" || paswd_txt.Text == "" || verivfy_txt.Text == "")
                {
                    MessageBox.Show("Please Fill In The Fields.", "McDonalds");
                    excount++;
                }
                try
                {
                    if (excount == 0)
                    {
                        connection1.Open();
                        OleDbCommand insert = new OleDbCommand("insert into users values (@user, @pass)", connection1);
                        insert.Parameters.AddWithValue("@user", user_txt.Text);
                        insert.Parameters.AddWithValue("@pass", paswd_txt.Text);
                        insert.ExecuteNonQuery();
                        connection1.Close();
                        user_txt.Clear();
                        paswd_txt.Clear();
                        verivfy_txt.Clear();
                        user_txt.Text = "Username";
                        user_txt.ForeColor = Color.Silver;
                        paswd_txt.Text = "Password";
                        paswd_txt.ForeColor = Color.Silver;
                        paswd_txt.PasswordChar = '\0';
                        verivfy_txt.Text = "Confirm Password";
                        verivfy_txt.ForeColor = Color.Silver;
                        verivfy_txt.PasswordChar = '\0';
                        count1 = 0; count2 = 0; count3 = 0;
                        MessageBox.Show("You have succesful created account.", "McDonalds");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The username was used.", "McDonalds");
                }
            }

            else
            {
                excount = 0;
                if (user_txt.Text == "Username" || paswd_txt.Text == "Password" || user_txt.Text == "" || paswd_txt.Text == "")
                {
                    MessageBox.Show("Please Fill In The Fields.", "McDonalds");
                    excount++;
                }
                try
                {
                    if (excount == 0)
                    {
                        connection1.Open();
                        OleDbCommand check = new OleDbCommand("SELECT * FROM users WHERE Username=@name AND Passwords=@passwd", connection1);
                        check.Parameters.AddWithValue("@name", user_txt.Text);
                        check.Parameters.AddWithValue("@passwd", paswd_txt.Text);
                        OleDbDataReader reader = check.ExecuteReader();
                        byte readercount = 0;
                        while (reader.Read())
                        {
                            readercount++;
                            break;
                        }
                        if (readercount > 0)
                        {
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is wrong.", "McDonalds");
                        }
                        connection1.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "McDonalds");
                }
            }
        }

        private void user_txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void user_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void user_txt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void paswd_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void verivfy_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
