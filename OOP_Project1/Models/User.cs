using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project1.Models
{
    //public ile her yerden erisilebilir.
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public string job { get; set; }

        public void Login(string loginDate)
        {
            System.Windows.Forms.MessageBox.Show($"{loginDate} tarihinde {userName} adli kullanici {password} sifresi ile giris yapmistir.");
        }

    }
}
