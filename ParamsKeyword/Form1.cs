using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParamsKeyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 6, 7, 8, 9 };
            Show("istanbul","Ankara","Izmir");
        }
        public void Add(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            MessageBox.Show(result.ToString());
        }
        public void Show(params string[] cities)
        {
            string msg="";
            foreach (string city in cities)
            {
                msg += city+" ";
            }
            MessageBox.Show(msg);
        }
    }
}
