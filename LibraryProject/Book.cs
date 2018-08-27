using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryProject
{
    public partial class Book : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Stuinfo;Integrated Security=True;");
        public Book()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand md = new SqlCommand(@"DELETE FROM Books
WHERE        (ISBN = '"+textBox3.Text+"')",con);

            md.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Successfully!.....");
            Display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand md = new SqlCommand(@"INSERT INTO Books
                         (Author, BookTitle, ISBN, Cell, Category)
VALUES        ('"+ textBox1.Text +"','"+ textBox2.Text +"','"+ textBox3.Text +"','"+ textBox4.Text +"','"+ comboBox1.Text +"')",con);

            md.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved.....");
            Display();
        }
        void Display()
        {
            SqlDataAdapter sdb = new SqlDataAdapter("Select * from Books", con);
            DataTable da = new DataTable();
            sdb.Fill(da);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in da.Rows)
            {
                int k = dataGridView1.Rows.Add();
                dataGridView1.Rows[k].Cells[0].Value = item["Author"].ToString();
                dataGridView1.Rows[k].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[k].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[k].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[k].Cells[4].Value = item[4].ToString();
               
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand md = new SqlCommand(@"UPDATE       Books
SET                Author ='"+textBox1.Text+"', BookTitle ='"+textBox2.Text+"', ISBN ='"+textBox3.Text+"', Cell ='"+textBox4.Text+"', Category ='"+comboBox1.Text+"'WHERE        (ISBN = '"+textBox3.Text+"')", con);

            md.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Edit Successfully!.....");
            Display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home c1 = new Home();
            c1.Show();
        }

        
    }
}
