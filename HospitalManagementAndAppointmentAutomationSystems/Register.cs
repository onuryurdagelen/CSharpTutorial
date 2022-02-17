using HospitalManagementAndAppointmentAutomationSystems.Models;
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
        void setLabelsUnvisible()
        {
            lblFirstName.Visible = true;
            lblLastname.Visible = true;
            lblIdentity.Visible = true;
            lblPassword.Visible = true;
        }
        void setLabelValues(string firstMsg,string lastMsg,string IdMsg,string passMsg)
        {
            setLabelsUnvisible();

            lblFirstName.Text = firstMsg;
            lblLastname.Text = lastMsg;
            lblIdentity.Text = IdMsg;
            lblPassword.Text = passMsg;

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            User user;
            user = new User();
            user.firstName = txtFirstName.Text;
            user.lastName = txtLastName.Text;
            user.Identity = txtIdentity.Text;
            user.password = txtPassword.Text;

            setLabelValues(user.frstMsg,user.lstMsg,user.IdMsg,user.passMsg);



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
