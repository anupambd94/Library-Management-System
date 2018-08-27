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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student s1 = new Student();
            s1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sbook sb1 = new Sbook();
            sb1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book b1 = new Book();
            b1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Final f1 = new Final();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bbook bb1 = new Bbook();
            bb1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rbook rb1 = new Rbook();
            rb1.Show();
        }
    }
}
