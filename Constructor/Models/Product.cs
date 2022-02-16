using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class Product
    {
        public string productName { get; set; }
        public DateTime createdDate { get; set; }

        //Her Sinifin gorunmez bir constructor'i vardir ama hic bir islem yapmaz.
        //Birden fazla constructor olusturulabilir.
        //Constructor class ismi ile kullanilabilir.
        public Product()
        {
            createdDate = DateTime.Now;
        }
        public Product(string productName)
        {
            createdDate = DateTime.Now;
            this.productName = productName;
        }

    }
}
