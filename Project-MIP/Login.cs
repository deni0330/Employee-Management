using Project_MIP;
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

namespace Proiect_MIP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
 
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;

            username = empUsername.Text;
            password = empPassword.Text;

            if (username == "")
            {
                MessageBox.Show("Please introduce the username!");

            }
            else if (password == "")
            {
                MessageBox.Show("Please introduce the password!");

            }
            else
            {

                if (empUsername.Text == "HR2023" && empPassword.Text == "admin")
                {

                    MainPageA mpA = new MainPageA();
                    mpA.Show();
                    this.Hide();
                }
                else
                  if (empUsername.Text == "EMP2023" && empPassword.Text == "employee")
                {

                    MainPageE mpE = new MainPageE();
                    mpE.Show();
                    this.Hide();
                }
                else
                  if (empUsername.Text != "HR2023" || empUsername.Text != "EMP2023" || empPassword.Text != "admin" || empPassword.Text != "employee")
                {
                    MessageBox.Show("Username or password is invalid. Please enter a valid username or password!");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForgotUP up = new ForgotUP();
            up.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

