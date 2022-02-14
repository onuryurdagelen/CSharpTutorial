using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFormOrnegi
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

        private void button1_Click(object sender, EventArgs e)
        {

            string tasitAdi;
            Tasit tasit = new Tasit();
            tasitAdi = textBox1.Text;
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = comboBox1.SelectedItem.ToString();
            dataGridView1.Rows[index].Cells[1].Value = tasitAdi;
            dataGridView1.Rows[index].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[index].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[index].Cells[4].Value = comboBox2.SelectedItem.ToString();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
