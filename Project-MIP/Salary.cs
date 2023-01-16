using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proiect_MIP;
using ClassLibrary;

namespace Project_MIP
{
    
    public partial class Salary : Form
    {
        
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Denisa;Initial Catalog=Employee Management;Integrated Security=True");

        WorkedDays wDays=new WorkedDays();
        bool flag = false;

        private void fetchdata()
        {

            if (empIDSearch.Text == "")
            {
                MessageBox.Show("Please enter the ID!");
            }
            else
                try
                {
                    Con.Open();
                    string query = "select * from EmployeeTbl where empID='" + empIDSearch.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                   
                    SqlDataReader rd=cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        if (rd[0].ToString() == empIDSearch.Text)

                        {
                            flag = true;
                            foreach (DataRow dr in dt.Rows)
                            {
                               

                                empFirstNameTb.Text = dr["empFirstName"].ToString();
                                empLastNameTb.Text = dr["empLastName"].ToString();

                                empPositionTb.Text = dr["empPosition"].ToString();
                                empEDateTb.Text = dr["empEmploymentDate "].ToString();



                            }
                            break;
                        }
                        else if(rd[0].ToString() != empIDSearch.Text)
                        { 
                           MessageBox.Show("Invalid ID! Please try to introduce a valid ID!");
                            
                        }
                        




                    }
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        }
        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        int total;
        private void button1_Click(object sender, EventArgs e)
        {
               Employee emp = new Employee();

            if (empWorkedDays.Text == "" || Convert.ToInt32(empWorkedDays.Text) > 21)
            {
                MessageBox.Show("Please enter a valid number of days!");
            }
            else
            {
                if (empPositionTb.Text == "Engineering Project Manager")
                {
                    total = (int)wDays.ProjectManager(Convert.ToInt32(empWorkedDays.Text));
                }
                else if (empPositionTb.Text == "Software Architect")
                {
                    total = (int)wDays.Architect(Convert.ToInt32(empWorkedDays.Text));
                }
                else if (empPositionTb.Text == "Product owner")
                {
                    total = (int)wDays.Product_owner(Convert.ToInt32(empWorkedDays.Text));
                }
                else if (empPositionTb.Text == "Technical Lead")
                {
                    total = (int)wDays.Technical_Lead(Convert.ToInt32(empWorkedDays.Text));
                }
                else if (empPositionTb.Text == "Quality Assurance Engineer")
                {
                    total = (int)wDays.Assurance_Engineer(Convert.ToInt32(empWorkedDays.Text));
                }
                else if (empPositionTb.Text == "Human Resources")
                {
                    total = (int)wDays.HR(Convert.ToInt32(empWorkedDays.Text));
                }
                else if (empPositionTb.Text == "Internship")
                {
                    total = (int)wDays.Internship(Convert.ToInt32(empWorkedDays.Text));
                }
                emp.FirstName = empFirstNameTb.Text;
                emp.LastName = empLastNameTb.Text;

                ViewDataTB.Text = "Employee ID: " +empIDSearch.Text + '\n' + emp.FullName()+ '\n' +"Employee Position: "+ empPositionTb.Text + '\n'+ '\n' + "Employee Worked Days: "+ empWorkedDays.Text + '\n'+"Total Amount: "+total.ToString();
                
            } 
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empIDSearch.Clear();
            empFirstNameTb.Clear();
            empEDateTb.Clear();
            empLastNameTb.Clear();
            empWorkedDays.Clear();
            empPositionTb.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainPageE mE = new MainPageE();
            mE.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void empEmploymentDateD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewDataTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void empFirstNameTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void empIDSearch_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
