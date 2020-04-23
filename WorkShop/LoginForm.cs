using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShop
{
    public partial class LoginForm : Form
    {
        string cs = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ja\source\repos\Warsztat\WorkShop\Login.mdf; Integrated Security = True";
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
            SqlConnection mySqlConnection = default(SqlConnection);
            mySqlConnection = new SqlConnection(cs);

            SqlCommand myCommand = default(SqlCommand);

            myCommand = new SqlCommand("SELECT Username, Password FROM Users WHERE Username = @Username AND @Password = Password");

            SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
            SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

            uName.Value = textBoxUsername;
            uPassword.Value = textBoxPassword;

            myCommand.Parameters.Add(uName);
            myCommand.Parameters.Add(uPassword);

            myCommand.Connection.Open();

            SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            if(myReader.Read() == true)
            {
                this.Hide();
                new WorkShopForm2().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
                if(mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Dispose();
            }
        }
       
        private void btnRegister_Click(object sender, EventArgs e)
            {
            this.Hide();
            new RegisterForm().Show();
        }


    }
}





