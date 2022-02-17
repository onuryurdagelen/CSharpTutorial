using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementAndAppointmentAutomationSystems
{
    public partial class Register : Form
    {
        Form1 login;
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRedirectLogin_Click(object sender, EventArgs e)
        {
            login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }
    }
}
