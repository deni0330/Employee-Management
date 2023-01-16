using Proiect_MIP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_MIP
{
    public partial class CompanyData : Form
    {

        public CompanyData()
        {
            InitializeComponent();
            populate();
            NrEmployee();
            NrFemale();
            NrMale();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Denisa;Initial Catalog=Employee Management;Integrated Security=True");

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainPageE mE = new MainPageE();
            mE.Show();
            this.Hide();
        }

        private void empGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NrEmployee()
        {

            Con.Open();
            SqlCommand query =new SqlCommand("select count(*) from EmployeeTbl ",Con);
            var count = query.ExecuteScalar();
            number.Text= count.ToString();
            Con.Close();
   ;

        }
        private void NrFemale()
        {

            Con.Open();
            SqlCommand query = new SqlCommand("select count(*) from EmployeeTbl where empGender='Female'", Con);
            var count = query.ExecuteScalar();
            numberF.Text = count.ToString();
            Con.Close();

            /*SqlCommand sql = new SqlCommand("SELECT * from EmployeeTbl");
            DataTable x = sql.ExecuteScalar();
            List<string> list = x.*/
        }

        private void NrMale()
        {

            Con.Open();
            SqlCommand query = new SqlCommand("select count(*) from EmployeeTbl where empGender='Male'", Con);
            var count = query.ExecuteScalar();
            numberM.Text = count.ToString();
            Con.Close();
        }

        private void populate()
        {
            Con.Open();
            string query = "select empId, empFirstName,empLastName,empPosition from EmployeeTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            empGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CompanyData_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}    

