using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.productName = txtProduct.Text;
            MessageBox.Show($"{product.productName} urunu {product.createdDate} tarihinde eklendi.");
        }

        private void btnCreateEasely_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtProduct.Text);
            MessageBox.Show($"{product.productName} urunu {product.createdDate} tarihinde eklendi.");
        }

        //Constructor (Yapici Metotlar)

    }
}
