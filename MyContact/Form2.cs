using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyContacts
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection connector2 = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\contact_db.accdb");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            txt_search_surname.Visible = false;
            dataGridView1.Refresh();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public void txt_search_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                connector2.Open();
                DataSet dtset = new DataSet();
                OleDbDataAdapter search = new OleDbDataAdapter("select * from contact_table where Name like'" + txt_search.Text + "%'", connector2);
                search.Fill(dtset);
                dataGridView1.DataSource = dtset.Tables[0];
                connector2.Close();
            }
            catch (Exception ex)
            {
                connector2.Close();
                MessageBox.Show(ex.Message, "Contact");
            }
        }

        private void txt_search_surname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connector2.Open();
                DataSet dtset = new DataSet();
                OleDbDataAdapter search = new OleDbDataAdapter("select * from contact_table where Surname like'" + txt_search_surname.Text + "%'", connector2);
                search.Fill(dtset);
                dataGridView1.DataSource = dtset.Tables[0];
                connector2.Close();
            }
            catch (Exception ex)
            {
                connector2.Close();
                MessageBox.Show(ex.Message, "Contact");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Name";
                txt_search_surname.Clear();
                label1.Visible = true;
                txt_search.Visible = true;
                label2.Visible = false;
                txt_search_surname.Visible = false;
            }
            else if (checkBox1.Checked == false)
            {
                checkBox1.Text = "Surname";
                txt_search.Clear();
                label1.Visible = false;
                label2.Visible = true;
                txt_search.Visible = false;
                txt_search_surname.Visible = true;
            }
        }
    }
}
