using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFormOrnegi
{
    class HavaTasitlari:Tasit
    {
        public int motorHacmi;
        public override int motorHacmiYaz(int motorHacmi)
        {
            return base.motorHacmiYaz(motorHacmi);
        }
    }
}
