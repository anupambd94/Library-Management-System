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
    public partial class Bbook : Form
    {
        public Bbook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home l1 = new Home();
            l1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Bbook_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Text;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = dateTimePicker2.Text;
        }
    }
}
