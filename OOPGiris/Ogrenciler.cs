using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGiris
{
    class Ogrenciler
    {
        private string ad;
        private string soyad;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }
        public string SOYAD { get { return soyad; } set { soyad = value; } }
    }
}
