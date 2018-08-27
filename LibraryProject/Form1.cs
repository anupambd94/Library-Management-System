using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Final f1 = new Final();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String user = "bubt";
                String pass="ponir";
            if(user==textBox1.Text && pass==textBox2.Text)
            {
                this.Hide();
                Start h1 = new Start();
                MessageBox.Show("Successfully Log In!.....");
                h1.Show();
            }
            else if (user != textBox1.Text && pass != textBox2.Text)
            {
                MessageBox.Show("Please Check your User_name and Password!.....");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
