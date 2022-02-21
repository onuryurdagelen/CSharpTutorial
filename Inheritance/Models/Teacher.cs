using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    //Ogretmen bir kullanicidir.
    public class Teacher:User
    {
        public Teacher(string _username, string _password) : base(_username, _password)
        {
        }

        public List<ClassRoom> classRooms { get; set; }

        public string  branch { get; set; }
       
        public void GiveHomework()
        {
            System.Windows.Forms.MessageBox.Show("being gave homework...");
        }
    }
}
