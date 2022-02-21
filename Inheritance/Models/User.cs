using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    public class User
    {
        public User(string _username,string _password)
        {
            userName = _username;
            password = _password;
            createdDate = DateTime.Now;
        }
        public string userName { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }

        public DateTime createdDate { get; set; }

        private int sample { get; set; }

        public string getFullName()
        {
            return $"{firstName} {lastName}";
        }
    }
}
