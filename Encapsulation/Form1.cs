using Encapsulation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.userName = txtUsername.Text;
            account.password = txtPassword.Text;
            MessageBox.Show($"Kullanici basariyla olusturulmustur. Kullancii adi: {account.userName}");
        }
    }
}
