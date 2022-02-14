using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFormOrnegi
{
    class Tasit
    {
        public string ad;
        public int hiz;
        public int Insankapasite;

        public virtual int disliSayisiYaz(int disSayisi)
        {
            return disSayisi;
        }

        public virtual int motorHacmiYaz(int motorHacmi)
        {
            return motorHacmi;
        }
    }
}
