using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurtAdamSaldirisiOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void setAlertMsg(string msg)
        {
            MessageBox.Show(msg);
        }

        public void setVisibleItems(bool control)
        {
            btnAttack.Visible = control;
            pcrWolf.Visible = control;
            lblHealth.Visible = control;
            lblHealthText.Visible = control;
            lblMe.Visible = control;
        }
        public void resetInputs()
        {
            txtUsername.Text = "";
            txtWeapon.Text = "";
            cmbEthnicity.Text = "";
            cmbMajor.Text = "";
        }
        Account account = new Account();

        public void setAccount()
        { 
            account.userName = txtUsername.Text;
            account.weapon = txtWeapon.Text;
            account.ethnicity = cmbEthnicity.GetItemText(cmbEthnicity.SelectedItem);
            account.major = cmbMajor.GetItemText(cmbMajor.SelectedItem);

            //Tum inputlar girildikten sonra tum inputlarin degerlerini sifirlar.
            //resetInputs();
            //Saldir buttonu,can bari ve kurt resmini gorunur hale getirir.
            setVisibleItems(true);

            lblHealth.Text = Convert.ToString(lblHealth.Width);

            lblMe.Text = Convert.ToString(lblHealth.Width);

        }
        private void btnAttack_Click(object sender, EventArgs e)
        {
            //Account account = new Account();
            account.Attack();
            lblHealth.Width -= account.damage;
            MessageBox.Show($"Dusmana {account.damage} hasar verildi.");
            lblHealth.Text = Convert.ToString(lblHealth.Width);

            if (lblHealth.Width <= 0)
            {
                MessageBox.Show("Tebrikler dusmani oldurdunuz");
                DialogResult dialogResult = MessageBox.Show("Tekrar oynamak ister misiniz?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //if code here....
                    setVisibleItems(false);
                    resetInputs();
                }
                else
                {
                    //else code here....
                    Application.ExitThread();
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           
            if (txtUsername.Text == "" ||
                txtWeapon.Text == "" ||
                cmbEthnicity.Text == "" ||
                cmbMajor.Text == "")
            {
                if (txtUsername.Text == "")
                {
                    setAlertMsg("Username alani bos olamaz");
                    return;
                }
                else if (cmbEthnicity.Text == "")
                {
                    setAlertMsg("Lutfen bir Irk seciniz!!!");
                    return;
                }
                else if (cmbMajor.Text == "")
                {
                    setAlertMsg("Lutfen bir brans seciniz");
                    return;

                }
                else
                {
                    setAlertMsg("Weapon alani bos olamaz");
                    return;
                }

            }

            setAccount();

        }
    }
}
	
