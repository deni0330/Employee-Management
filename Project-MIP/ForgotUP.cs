using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proiect_MIP;

namespace Project_MIP
{
    public partial class ForgotUP : Form
    {
        public ForgotUP()
        {
            InitializeComponent();
        }
        SqlConnection Con1 = new SqlConnection(@"Data Source=Denisa;Initial Catalog=Employee Management;Integrated Security=True");

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ForgotUP_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empIDSearch_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            if (empIDSearch.Text == "")
            {
                MessageBox.Show("Please enter the ID!");
            }
            else
                try
                {
                    Con1.Open();
                    string query = "select * from Login where ID='" + empIDSearch.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con1);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        bool T = true;
                        empFName.Text = dr["fName"].ToString();
                        empLName.Text = dr["lName"].ToString();
                        username.Text = dr["username"].ToString();
                        password.Text = dr["password"].ToString();

                        empFName.Visible = T;
                        empLName.Visible = T;
                        username.Visible = T;
                        password.Visible = T;
                    }
                    Con1.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
