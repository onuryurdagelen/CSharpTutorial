using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriyeVeriDondurenMethodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string GetName()
        {
            Random random = new Random();
            int number = random.Next(1, 5);
            return "onur";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void btnGetName_Click(object sender, EventArgs e)
        {
            string name = GetName();
            MessageBox.Show(name);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int result = Calculate(5, 7);
            MessageBox.Show(Convert.ToString(result));
        }
        public int Calculate(int number1, int number2)
        {
            int number = number1 * number2;
            return number;

        }
    }
}
