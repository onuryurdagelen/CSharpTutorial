using ConstructorLoginOrnegi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorLoginOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        User user;
        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User("onuryurdagelen","12345");
        }
        //Login butonuna tikladigimizda username ve password degerleri kontrol edilir.Dogruysa Login formuna redirect edilir.
        //Hataliysa hata mesaji yazdirilir.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            if (userName == user.userName && password == user.password)
            {
                Login login = new Login(user);
                login.Show(); // 2.form acilir.
                this.Hide(); // Su anda bulundugumuz formu kapatir.
            }
            else
            {
                MessageBox.Show("Hatali giris!!!");
            }
        }
    }
}
