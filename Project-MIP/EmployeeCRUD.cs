using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Proiect_MIP;
using System.Collections.Generic;

namespace Project_MIP
{
    public partial class EmployeeCRUD : Form
    {

        public EmployeeCRUD()
        {
            InitializeComponent();
            populate();
        
        }

        SqlConnection Con = new SqlConnection(@"Data Source=Denisa;Initial Catalog=Employee Management;Integrated Security=True");
        
       
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPageA_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( empFirstNameTb.Text == "" || empLastNameTb.Text == "" || empAddressTb.Text == "" || empPhoneTb.Text == "")
            {
                MessageBox.Show("Missing information. Please fill in all the information in the blank boxes!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into EmployeeTbl values('" + empIDTb.Text + "','" + empFirstNameTb.Text + "','" + empLastNameTb.Text + "','" + empGenderDb.SelectedItem.ToString() + "','" + empBirthDateD.Value.Date + "','" + empAddressTb.Text + "','" + empPhoneTb.Text + "','" + empEducationTb.SelectedItem.ToString() + "','" + empPositionDb.SelectedItem.ToString() + "','" + empEmploymentDateD.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully added!");
                    Con.Close();
                    populate();

                    

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                if (empPositionDb.Text == "Human Resources")
                {
                    Con.Open();
                    string val = "HR2023";
                    string pas = "admin";

                    string query1 = "insert into Login values('" + empIDTb.Text + "','" + empLastNameTb.Text + "','" + empFirstNameTb.Text + "','" + val + "','" + pas + "')";
                    SqlCommand cmd=new SqlCommand(query1, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully added in Login!");
                    Con.Close();

                }
                else if (empPositionDb.Text == "Internship" || empPositionDb.Text == "Software Architect" || empPositionDb.Text == "Product owner" || empPositionDb.Text == "Technical Lead" || empPositionDb.Text == "Quality Assurance Engineer" || empPositionDb.Text == "Engineering Project Manager")
                {
                    Con.Open();
                    string val = "EMP2023";
                    string pas = "employee";
                    string query1 = "insert into Login values('" + empIDTb.Text + "','" + empLastNameTb.Text + "','" + empFirstNameTb.Text + "','" + val + "','" + pas + "')";
                    SqlCommand cmd = new SqlCommand(query1, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully added in Login!");
                    Con.Close();
                }

            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            empGrid.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void empBirthDateD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          empIDTb.Text = empGrid.SelectedRows[0].Cells[0].Value.ToString();
          empFirstNameTb.Text=empGrid.SelectedRows[0].Cells[1].Value.ToString();
          empLastNameTb.Text= empGrid.SelectedRows[0].Cells[2].Value.ToString();
          empGenderDb.Text=empGrid.SelectedRows[0].Cells[3].Value.ToString();
          empBirthDateD.Text=empGrid.SelectedRows[0].Cells[4].Value.ToString();
          empAddressTb.Text=empGrid.SelectedRows[0].Cells[5].Value.ToString();
          empPhoneTb.Text = empGrid.SelectedRows[0].Cells[6].Value.ToString();
          empEducationTb.Text= empGrid.SelectedRows[0].Cells[7].Value.ToString();
          empPositionDb.Text=empGrid.SelectedRows[0].Cells[8].Value.ToString();
          empEmploymentDateD.Text=empGrid.SelectedRows[0].Cells[9].Value.ToString();
         
        }

        private void DeleteButon_Click(object sender, EventArgs e)
        {
            if(empIDTb.Text == " ")
            {
                MessageBox.Show("Please enter the ID!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from EmployeeTbl where empID='" + empIDTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully deleted!");
                    Con.Close();
                    populate();
                   

                }
                catch(Exception Ex)
                {
                        MessageBox.Show(Ex.Message);

                }
                
                if (empPositionDb.Text == "Human Resources")
                {
                    Con.Open();
                    string query1 = "delete from Login where ID='" + empIDTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query1, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully deleted from Login!");
                    Con.Close();

                }
                else if (empPositionDb.Text == "Internship" || empPositionDb.Text == "Software Architect" || empPositionDb.Text == "Product owner" || empPositionDb.Text == "Technical Lead" || empPositionDb.Text == "Quality Assurance Engineer" || empPositionDb.Text == "Engineering Project Manager")
                {
                    Con.Open();
                    string query1 = "delete from Login where ID='" + empIDTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query1, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully deleted from Login!");
                    Con.Close();
                }
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if ( empFirstNameTb.Text == "" || empLastNameTb.Text == "" || empAddressTb.Text == "" || empPhoneTb.Text == "")
            {
                MessageBox.Show("Missing information. Please fill in all the information in the blank boxes!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update EmployeeTbl set empID='" + empIDTb.Text + "',empFirstName='" + empFirstNameTb.Text + "',empLastName='" + empLastNameTb.Text + "',empGender='" + empGenderDb.SelectedItem.ToString() + "',empBirthDate='" + empBirthDateD.Value.Date + "',empAddress='" + empAddressTb.Text + "',empPhone='" + empPhoneTb.Text + "', empEducation='" + empEducationTb.SelectedItem.ToString() + "',empPosition='" + empPositionDb.SelectedItem.ToString() + "',empEmploymentDate='" + empEmploymentDateD.Value.Date + "'where empID='" + empIDTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully updated!");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
               
                if (empPositionDb.Text == "Human Resources")
                {
                    Con.Open();
                    string val = "HR2023";
                    string pas = "admin";
                    string query1 = "update Login set ID='" + empIDTb.Text + "', fName='" + empFirstNameTb.Text + "',lname='" + empLastNameTb.Text + "',username='" + val + "',password='" + pas + "'where ID='" + empIDTb.Text + "';"; 
                    SqlCommand cmd = new SqlCommand(query1, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully updated in Login!");
                    Con.Close();

                }
                else if (empPositionDb.Text == "Internship" || empPositionDb.Text == "Software Architect" || empPositionDb.Text == "Product owner" || empPositionDb.Text == "Technical Lead" || empPositionDb.Text == "Quality Assurance Engineer" || empPositionDb.Text == "Engineering Project Manager")
                {
                    Con.Open();
                    string val = "EMP2023";
                    string pas = "employee";
                    string query1 = "update Login set ID='"+empIDTb.Text+"', fName='" + empFirstNameTb.Text + "',lname='" + empLastNameTb.Text + "',username='" + val + "',password='" + pas + "'where ID='" + empIDTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query1, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully updated in Login!");
                    Con.Close();
                }

            }

            }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainPageA mA = new MainPageA();
            mA.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empFirstNameTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void empEducationTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empIDTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            empIDTb.Clear();
            empFirstNameTb.Clear();
            empLastNameTb.Clear();
            empAddressTb.Clear();
            empPhoneTb.Clear();
          
        }
    }

    
}

