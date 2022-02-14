using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGiris
{
    class Kuslar
    {
        public string tur;
        public int ayak;
        public string ad;
        public bool ucabiliyorMu;

        public virtual string sesCikart(string ses)
        {
            return ses;
        }
        
    }
}
