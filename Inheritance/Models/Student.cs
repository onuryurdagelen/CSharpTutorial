using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    //Student bir Userdir.
    public class Student:User
    {
        

        public Student(string _schoolNumber,string _username, string _password) : base(_username, _password)
        {
            
            schoolNumber = _schoolNumber;
        }

        public ClassRoom classRoom { get; set; } // 1-A
        public string schoolNumber { get; set; } //141

        public List<Teacher> teachers { get; set; }

        public List<Lesson> lessons { get; set; }

        public void DoHomework()
        {
            System.Windows.Forms.MessageBox.Show("Doing homerwork...");
        }
    }
}
