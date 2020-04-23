using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShop
{
    public partial class LoginForm : Form

    { 
        public LoginForm()
        {
            InitializeComponent();
    }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.White;
           
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPassword.PasswordChar = '*';
            panel2.BackColor = Color.Black;
            panel1.BackColor = Color.White;
           
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ja\source\repos\Warsztat\WorkShop\Login.mdf; Integrated Security = True"); // making connection   
            string query = "SELECT COUNT(*) FROM Users WHERE Username='" + textBoxUsername + "' AND Password='" + textBoxPassword + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            //if (dt.Rows.Count == 1)
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new WorkShopForm2().Show();
              }
            else
                MessageBox.Show("Invalid username or password");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }
    }
}
