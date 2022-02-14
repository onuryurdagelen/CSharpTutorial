using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetValue();
        }
        //Geriye Deger Dondurmeyen Methodlar
        public void Greeting()
        {
            MessageBox.Show("Hello I'm a method");
        }
        int value = 0;
        public void ResetValue()
        {
            value = 0;
            label1.Text = Convert.ToString(value);
        }
        public void Assign()
        {
            label1.Text = Convert.ToString(value);
        }
        public void IncreaseValue()
        {
            value++;
            //value = Convert.ToInt32(label1.Text);
            Assign();


        }
        public void DecreaseValue()
        {
            value--;
            //value = Convert.ToInt32(label1.Text);
            Assign();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Greeting();
            ResetValue();
        }

        private void increment_Click(object sender, EventArgs e)
        {
            IncreaseValue();

        }

        private void decrement_Click(object sender, EventArgs e)
        {
            DecreaseValue();
        }
    }
}
