using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;

namespace Project_MIP
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            NrMale();
            NrFemale();
            NrEmployee();
            Salary();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Denisa;Initial Catalog=Employee Management;Integrated Security=True");
        WorkedDays wd=new WorkedDays();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainPageA mA= new MainPageA();
            mA.Show();
            this.Hide();

        }
        private void NrEmployee()
        {

            Con.Open();
            SqlCommand query = new SqlCommand("select count(*) from EmployeeTbl ", Con);
            var count = query.ExecuteScalar();
            number.Text = count.ToString();
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
        }

        private void NrMale()
        {

            Con.Open();
            SqlCommand query = new SqlCommand("select count(*) from EmployeeTbl where empGender='Male'", Con);
            var count = query.ExecuteScalar();
            numberM.Text = count.ToString();
            Con.Close();
        }
      
        private void Salary()
        {
            Con.Open();
            string query = "select * from Salary";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            empGrid.DataSource = ds.Tables[0];
            Con.Close();


        }
        private void numberF_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void empGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
