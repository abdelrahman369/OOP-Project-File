using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = "Admin";
            string Password = "Admin369";
            if ((textBox1.Text == Username) && (textBox2.Text == Password))
                MessageBox.Show("Login Successfull!");
            else
                MessageBox.Show("Login Failed! Please Check Username &Password again");
        }
    }
}
