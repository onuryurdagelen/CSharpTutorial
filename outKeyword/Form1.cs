using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace outKeyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZar1_Click(object sender, EventArgs e)
        {

        }
        public int getRandomNumber()
        {
            Random random = new Random();
            int randomVal = random.Next(1, 7);
            return randomVal;
        }
 
        private void btnRun_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            string msg  = Play(out number1, out number2);
            Console.WriteLine(number1+" "+number2);
            lblNumber3.Text = number1.ToString();
            lblNumber4.Text = number2.ToString();
            MessageBox.Show(msg);
            
            
        }
        //Ref keyword'unu kullanmadan once default deger atanmalidir.Atanmazsa hata aliriz.
        public string Play(out int number1,out int number2)
        {
            number1 = getRandomNumber();
            number2 = getRandomNumber();
            string msg;
            if (number1 == number2)
            {
                msg = "Tebrikler Kazandiniz!!!";
            }
            else
            {
                msg = "Maalesef Kaybettiniz!!!";
            }
            return msg;
        }
    }
}
