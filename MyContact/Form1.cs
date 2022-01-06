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
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace MyContacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection connector = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\nihadallahveranov\Visual Studio Projects\MyContacts\MyContacts\bin\Debug\contact_db.accdb");
        Form2 f2 = new Form2();
        public void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            maskedTextBox1.Visible = true;
            button1.Visible = true;
            button1.Text = "Insert";
        }

        public void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
            button1.Text = "Update";
        }

        public void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            maskedTextBox1.Visible = false;
            button1.Visible = true;
            button1.Text = "Delete";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            list();
            button1.Visible = false;
        }

        public void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f2.checkBox1.Visible = true;
                f2.label2.Visible = false;
                f2.txt_search_surname.Visible = false;
                f2.label1.Visible = true;
                f2.txt_search.Visible = true;
                f2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was developed by Nihad Allahveranov\nThis program can add, update, delete, search operations on the contact\nYou can export the contact information to an excel file through the program.", "About the program");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Insert")
            {
                if (txt_name.Text=="" || txt_surname.Text=="" || maskedTextBox1.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Contact");
                }
                else
                {
                    try
                    {
                        connector.Open();
                        OleDbCommand insertcmd = new OleDbCommand("insert into contact_table values (@name, @surname, @phone)", connector);
                        insertcmd.Parameters.AddWithValue("@name", txt_name.Text);
                        insertcmd.Parameters.AddWithValue("@surname", txt_surname.Text);
                        insertcmd.Parameters.AddWithValue("@phone", maskedTextBox1.Text);
                        insertcmd.ExecuteNonQuery();
                        connector.Close();
                        MessageBox.Show("Succesful Insert", "Contact");
                        txt_name.Clear();
                        txt_surname.Clear();
                        maskedTextBox1.Clear();
                    }
                    catch (Exception ex)
                    {
                        connector.Close();
                        MessageBox.Show(ex.Message, "Contact");
                    }
                }
            }
            else if (button1.Text == "Update")
            {
                if (txt_name.Text == "" || txt_surname.Text == "" || maskedTextBox1.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Contact");
                }
                else
                {
                    try
                    {
                        connector.Open();
                        OleDbCommand updatecmd = new OleDbCommand("update contact_table set Name=@name,Surname=@surname where Phone=@phone", connector);
                        updatecmd.Parameters.AddWithValue("@name", txt_name.Text);
                        updatecmd.Parameters.AddWithValue("@surname", txt_surname.Text);
                        updatecmd.Parameters.AddWithValue("@phone", maskedTextBox1.Text);
                        updatecmd.ExecuteNonQuery();
                        connector.Close();
                        MessageBox.Show("Succesful Update", "Contact");
                        txt_name.Clear();
                        txt_surname.Clear();
                        maskedTextBox1.Clear();
                    }
                    catch (Exception ex)
                    {
                        connector.Close();
                        MessageBox.Show(ex.Message, "Contact");
                    }
                }
                
            }
            else if (button1.Text == "Delete")
            {
                if (txt_name.Text == "" || txt_surname.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Contact");
                }
                else
                {
                    try
                    {
                        connector.Open();
                        OleDbCommand dltcmd = new OleDbCommand("delete from contact_table where Name=@name and Surname=@surname", connector);
                        dltcmd.Parameters.AddWithValue("@name", txt_name.Text);
                        dltcmd.Parameters.AddWithValue("@surname", txt_surname.Text);
                        dltcmd.ExecuteNonQuery();
                        connector.Close();
                        MessageBox.Show("Succesful Delete", "Contact");
                        txt_name.Clear();
                        txt_surname.Clear();
                    }
                    catch (Exception ex)
                    {
                        connector.Close();
                        MessageBox.Show(ex.Message, "Contact");
                    }
                }
               
            }



        }

        public void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f2.checkBox1.Visible = false;
                f2.label1.Visible = false;
                f2.label2.Visible = false;
                f2.txt_search_surname.Visible = false;
                f2.txt_search.Visible = false;
                f2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Contact");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txt_name.Visible = true;
            txt_surname.Visible = true;
            maskedTextBox1.Visible = true;
            button1.Visible = false;
        }
        private void list()
        {
            try
            {
                connector.Open();
                OleDbDataAdapter list = new OleDbDataAdapter("select * from contact_table", connector);
                DataSet dtset = new DataSet();
                list.Fill(dtset);
                f2.dataGridView1.DataSource = dtset.Tables[0];
                list.Update(dtset);
                connector.Close();
            }
            catch (Exception ex)
            {
                connector.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Workbook workbook = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            app.Visible = false;
            for (int i = 1; i <= f2.dataGridView1.ColumnCount; i++)
            {
                if (i == 1)
                {
                    worksheet.Cells[1, i].ColumnWidth = 20;
                }
                else if (i == 2)
                {
                    worksheet.Cells[1, i].ColumnWidth = 25;
                }
                else
                {
                    worksheet.Cells[1, i].ColumnWidth = 30;
                }
                worksheet.Cells[1, i] = f2.dataGridView1.Columns[i-1].HeaderText;
                worksheet.Cells[1, i].Style.Font.Size = 16;
                worksheet.Cells[1, i].Font.Bold = true;
                worksheet.Cells[1, i].Style.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            }
            for ( int i = 0; i < f2.dataGridView1.RowCount-1; i++)
            {
                for ( int j = 0; j < f2.dataGridView1.ColumnCount; j++)
                {
                    string temp = f2.dataGridView1.Rows[i].Cells[j].Value.ToString();
                    worksheet.Cells[i + 2, j + 1] = temp;
                    worksheet.Cells[i+2, j+1].Style.Font.Size = 14;
                    worksheet.Cells[i+2, j+1].Font.Bold = false;
                    worksheet.Cells[i+2, j+1].Style.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                }
            }
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = "Excel File(.xlsx)|*.xlsx";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                worksheet.SaveAs(savefiledialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                workbook.Close(false, Type.Missing, Type.Missing);
                app.Visible = false;
                MessageBox.Show("Your excel file has been successfully created and exported", "Contact");
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Excel.Application app2 = new Excel.Application();
                Excel.Workbooks app_book = app2.Workbooks;
                Excel.Workbook book = app_book.Open(openfile.FileName);
                app2.Visible = true;
            } 
        }
    }
}
