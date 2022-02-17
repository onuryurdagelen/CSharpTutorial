using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementAndAppointmentAutomationSystems.Models
{
    
    public class User
    {
       

        string _firstName;
        string _lastName;
        string _identify;
        string _password;


        public string lstMsg { get; set; }
        public string frstMsg { get; set; }
        public string IdMsg { get; set; }
        public string passMsg { get; set; }



        public string lastName { get { return _lastName; } 
            set {
                if (value.Length == 0)
                {
                    lstMsg = "***Lastname bos olamaz";
                }
                if (value.Length < 4)
                {
                    lstMsg = "***Lastname en az 4 karakter olmalidir.";
                }
                _lastName = value;
            } 
        
        }

        public string Identity { get { return _identify; } 
            set {
                if (value.Length == 0)
                {
                    IdMsg = "***Identity bos olamaz";
                }
                _identify = value;
            } 
        
        }

        public string password {
            get { return _password; }
            set {
                if (value.Length == 0)
                {
                    passMsg = "***Password bos olamaz";
                }
                _password = value;
            } 
        }
        public string firstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length == 0)
                {
                    frstMsg = "***Firstname bos olamaz";
                }
                _firstName = value;
            }
        }


    }
}
