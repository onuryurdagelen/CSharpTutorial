using Inheritance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            ClassRoom clsRoom = new ClassRoom();
            clsRoom.number = "1";
            clsRoom.character = "A";

            Teacher teacher = new Teacher("emirhan124","123");

            User user = new User("onuryurdagelen","onur12356");

            Student student = new Student("144","onuryurdagelen","onur123");
            student.classRoom = clsRoom;
            student.classRoom.FullName();
            student.firstName = "Onur";
            student.lastName = "Yurdagelen";

            student.teachers.Add(teacher);

            MessageBox.Show(teacher.firstName);

            MessageBox.Show(student.getFullName());
        
            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //List type

        List<Teacher> teachers = new List<Teacher>();

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtUsername.Text, txtPassword.Text);
            teacher.branch = txtBranch.Text;
            teachers.Add(teacher);
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            lstTeachers.Items.Clear();
            foreach (Teacher teacher in teachers)
            {
                lstTeachers.Items.Add($"Kullanici adi= {teacher.userName} brans adi = {teacher.branch}");
            }
        }
    }
}
