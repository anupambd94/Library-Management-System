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
    public partial class Sbook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Stuinfo;Integrated Security=True;");
        public Sbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home k1 = new Home();
            k1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ISBN")
            {

                SqlDataAdapter sdb = new SqlDataAdapter("Select * from Books Where (ISBN like '%" + textBox1.Text + "%')", con);
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
            else if (comboBox1.Text == "Author")
            {

                SqlDataAdapter sdb = new SqlDataAdapter("Select * from Books Where (Author like '%" + textBox1.Text + "%')", con);
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
        }
    }
}
