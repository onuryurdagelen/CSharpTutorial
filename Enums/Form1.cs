using Enums.Enums;
using Enums.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            cbDifficulty.Items.Add(Difficulty.Easy);
            cbDifficulty.Items.Add(Difficulty.Medium);
            cbDifficulty.Items.Add(Difficulty.Hard);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.userName = txtUserName.Text;
            game.difficulty = (Difficulty)cbDifficulty.SelectedItem;
            game.gender = rbErkek.Checked ? Gender.Male : Gender.Female;
        }
        //enum
        //Alabilecekleri degerler belli ve bunun disina cikmayacak degerlerde kullanilir.

        //cinsiyet => erkek,kadin
        //medeni hal => evli,bekar
        //dini==>musluman,yahudi,hristiyan
    }
}
