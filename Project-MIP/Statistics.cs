using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;
using System.Linq;

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
            Seniority();
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
            

        }
        private void NrFemale()
        {

            Con.Open();
            string query = "select * from EmployeeTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {

                Employee emp = new Employee();
                emp.FirstName = dr[1].ToString();
                emp.LastName = dr[2].ToString();
                emp.Gender = dr[3].ToString();
                emp.BirthDate = dr[4].ToString();
                emp.Address = dr[5].ToString();
                emp.Phone = dr[6].ToString();
                emp.Education = dr[7].ToString();
                emp.Position = dr[8].ToString();
                emp.EmployementDate = dr[9].ToString();
                emp.EmpID = int.Parse(dr[0].ToString());


                employees.Add(emp);

            }
            numberF.Text = employees.Count(x => x.Gender == "Female").ToString();

            Con.Close();
        }

        private void NrMale()
        {

            Con.Open();
            string query = "select * from EmployeeTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                
                Employee emp = new Employee();
                emp.FirstName = dr[1].ToString();
                emp.LastName = dr[2].ToString();
                emp.Gender = dr[3].ToString();
                emp.BirthDate = dr[4].ToString();
                emp.Address = dr[5].ToString();
                emp.Phone = dr[6].ToString();
                emp.Education = dr[7].ToString();
                emp.Position = dr[8].ToString();
                emp.EmployementDate = dr[9].ToString();
                emp.EmpID = int.Parse(dr[0].ToString());


                employees.Add(emp);

            }
            numberM.Text = employees.Count(x => x.Gender == "Male").ToString();
           
            Con.Close();
        }
      
        private void Salary()
        {
            Con.Open();
            string query = "select * from Salary order by salary desc";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            empGrid.DataSource = ds.Tables[0];
            Con.Close();


        }

        private void Seniority()
        {
            Con.Open();
            string query = "select empId, empFirstName,empLastName,empPosition,empEmploymentDate  from EmployeeTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            empGrid2.DataSource = ds.Tables[0];
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
