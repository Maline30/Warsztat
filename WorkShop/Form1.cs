using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPassword.PasswordChar = '*';
            panel2.BackColor = Color.Black;
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            textBoxEmail.Clear();
            panel3.BackColor = Color.Black;
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;

        }
    }
}
