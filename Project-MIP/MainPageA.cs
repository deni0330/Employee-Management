using Proiect_MIP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_MIP
{
    public partial class MainPageA : Form
    {
        public MainPageA()
        {
            InitializeComponent();
        }

        private void MainPageA_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EmployeeCRUD cr=new EmployeeCRUD();
            cr.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Statistics statistics=new Statistics();
            statistics.Show();
            this.Hide(); 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
