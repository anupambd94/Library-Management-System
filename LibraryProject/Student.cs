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
    public partial class Student : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Stuinfo;Integrated Security=True;");
        public Student()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Students
WHERE        (ID = '"+ textBox1.Text +"')", sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Delete Successfully!.....");
            Display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home m1 = new Home();
            m1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text ="";
            textBox2.Text="";
            textBox3.Text ="";
            textBox4.Text="";
            textBox5.Text ="";
            textBox6.Text="";
            comboBox4.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand cmd=new SqlCommand(@"INSERT INTO Students
                         (ID, First, Last, Email, Mobile, Address, Year, Gender, Department)
VALUES        ('"+ textBox1.Text +"','"+ textBox2.Text +"','"+ textBox3.Text +"','"+ textBox4.Text +"','"+ textBox5.Text +"','"+ textBox6.Text +"','"+ comboBox4.Text +"','"+ comboBox1.Text +"','"+ comboBox3.Text +"')",sc);

            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Successfully Saved.....");
            Display();
        }
        void Display()
        {
            SqlDataAdapter sda=new SqlDataAdapter("Select * from Students",sc);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n=dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value=item["ID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value=item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value=item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value=item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value=item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value=item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value=item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value=item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value=item[8].ToString();
            }
    }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE       Students
SET                ID ='"+textBox1.Text+"', First ='"+textBox2.Text+"', Last ='"+textBox3.Text+"', Email ='"+textBox4.Text+"', Mobile ='"+textBox5.Text+"', Address ='"+textBox6.Text+"', Year ='"+comboBox4.Text+"', Gender ='"+comboBox1.Text+"', Department ='"+comboBox3.Text+"'WHERE        (ID = '"+textBox1.Text+"')", sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Update Successfully!.....");
            Display();
        }

       
           
        

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (comboBox7.Text == "ID")
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from Students Where (ID like '%" + textBox7.Text + "%')", sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
}

}
