using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Rotation: {fromText.Text} - {ToText.Text} Date: {dateTimePicker1.Text} Time: {maskedTextBox1.Text} <Passenger Infos>" +
                $"Full Name: {textBox1.Text} ID: {maskedTextBox1.Text} Phone: {maskedTextBox3.Text} ");
            MessageBox.Show("Recording Passenger Process successfully done!");
        }

        private void btnReverseRotation_Click(object sender, EventArgs e)
        {
            string tempFromText = fromText.Text;
            if (fromText.Text != ToText.Text)
            {
                fromText.Text = ToText.Text;
                ToText.Text = tempFromText;
            }
           
            
        }
    }
}
