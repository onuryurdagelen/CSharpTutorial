using OOP_Project1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //user 1
        string userName = "onuryurdagelen";
        string password = "12345";
        int age = 27;
        string job = "developer";

        private void btnUser_Click(object sender, EventArgs e)
        {
            //user1
            User user = new User();
            user.userName = "abdullah";
            user.password = "abdullah123";
            user.age = 27;
            user.job = "developer";
            MessageBox.Show($"Kullanici Adi: {user.userName} - password: {user.password}");
            //Random random = new Random();

            //user2
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            Tree tree = new Tree();
            tree.age = 4;
            tree.color= "green";
            tree.height = 165;
            tree.type = "filiz";
            MessageBox.Show($"Agac turu: {tree.type} - Agac uzunlugu: {tree.height} cm");
        }
        public void resetFields()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
        public void setAlertMsg(string msg)
        {
            MessageBox.Show(msg);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = txtUsername.Text;
            user.password = txtPassword.Text;
            string loginDate = DateTime.Now.ToString();

            if (user.userName == "" || user.password == "")
            {
                if (user.userName == null)
                {
                    setAlertMsg("Lutfen Username kismini doldurunuz.");
                }
                else if (user.password == "")
                {
                    setAlertMsg("Lutfen password kismini doldurunuz");
                }
                return;
            }
            user.Login(loginDate);
            resetFields();
        }

        //user details



    }
}
