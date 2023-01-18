using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proiect_MIP;
using System.Data.SqlClient;
using System.Linq;

namespace Project_MIP
{
    public partial class EmployeeData : Form
    {
        public EmployeeData()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Denisa;Initial Catalog=Employee Management;Integrated Security=True");
        Employee emp = new Employee();

        private void fetchdata()
        {
            List<Employee> employee = new List<Employee>();
            if (empIDSearch.Text == "")
            {
                MessageBox.Show("Please enter the ID!");
            }
            else
                try
                {
                    Con.Open();
                    string query = "select * from EmployeeTbl";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    
                    foreach (DataRow dr in dt.Rows)
                    {
                        emp=new Employee();
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

                       
                        employee.Add(emp);


                    }
                 
                    Employee result=employee.Where(e => e.EmpID == int.Parse(empIDSearch.Text)).First();
                    

                    bool T = true;
                    empFName.Text = result.FirstName;
                    empLName.Text = result.LastName;
                    empGen.Text = result.Gender;
                    empBD.Text = result.BirthDate;
                    empAd.Text = result.Address;
                    empPho.Text = result.Phone;
                    empEd.Text = result.Education;
                    empPos.Text = result.Position;
                    empEdate.Text = result.EmployementDate;

                    empFName.Visible = T;
                    empLName.Visible = T;
                    empGen.Visible = T;
                    empBD.Visible = T;
                    empAd.Visible = T;
                    empPho.Visible = T;
                    empEd.Visible = T;
                    empPos.Visible = T;
                    empEdate.Visible = T;

                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empIDTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainPageE mE = new MainPageE();
            mE.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void empFName_Click(object sender, EventArgs e)
        {

        }
    }
}
