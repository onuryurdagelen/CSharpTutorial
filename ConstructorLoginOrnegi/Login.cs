using ConstructorLoginOrnegi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConstructorLoginOrnegi
{
    public partial class Login : Form
    {
        User user;
        //Login constructorunda yeni bir user class'i tanimladik.Globalde tanimladigimiz user'a esitledik.
        public Login(User _user)
        {
            InitializeComponent();
            user = _user;
        }
        //Login formu yuklendiginde yazi yazdirilacak.
        private void Login_Load(object sender, EventArgs e)
        {
            lblMessage.Text = $"Hosgeldiniz {user.userName}";
        }
    }
}
