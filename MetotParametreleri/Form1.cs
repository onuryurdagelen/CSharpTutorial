using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotParametreleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOkcu_Click(object sender, EventArgs e)
        {

            Attack(btnOkcu.Text,300);
        }

        private void btnMage_Click(object sender, EventArgs e)
        {

            Attack(btnMage.Text,200);

        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {

            Attack(btnWarrior.Text,100);
        }
        /// <summary>
        /// Sadece classlar kullanabilir
        /// </summary>
        /// <param name="attackStype">Hangi stil ile vurus yapilacagi girilmelidir.</param>
        /// <param name="damage">Verilecek hasar girilir.</param>
        public void Attack(string attackStype,int damage=200)
        {
            MessageBox.Show($"Dusmana {attackStype} ile {damage} hasar verildi.");
        }
        //default degerler en sona yazilir.
       
        private void btnAssassin_Click(object sender, EventArgs e)
        {
            //Attack(btnWarrior.Text);
            Attack(damage: 230, attackStype: "kilic");
        }
        //Metot Imzasi
        /// <summary>
        /// Sadece Npc ler kullanabilir
        /// </summary>
        public void Attack()
        {
            MessageBox.Show($"Dusmana 100 hasar verildi.");
        }
        private void btnNpc_Click(object sender, EventArgs e)
        {
            Attack(); 
        }
    }
}
