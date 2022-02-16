using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorLoginOrnegi.Models
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }

        public User(string _username,string _password)
        {
            userName = _username;
            password = _password;
        }
    }
}
