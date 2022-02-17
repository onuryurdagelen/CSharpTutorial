using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Encapsulation.Models
{
    public class Account
    {
        public Account()
        {
            int a = 5; //local variable;

            
        }
        int b = 5; // field

        string _userName;

        //Encapsulation(Kapsulleme - Yonetme)
        public string userName {
            get { return "Mr." + _userName; }
            set {
                if (value.Length > 3)
                {
                    _userName = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Kullanici adi en az 4 karakter olmalidir.");
                    Application.Restart();
                }
            }
        
        }
        public string password { get; set; }


    }
}
