using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Models
{   
    //class yapilari en dusuk internal olabilir.Yazilmazsa alabilecegi en dusuk erisim belirtecini alir.
    public class Sample
    {
        public string publicProperty { get; set; }

        internal string internalProperty { get; set; }

        private string privateProperty { get; set; }
        public object Systems { get; private set; }

        string privateVariable; //yazilmazsa private'tir.

        internal void Test()
        {
            System.Windows.Forms.MessageBox.Show("test");
        }
    }
}
