using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassupg1
{
    class Resa
    {
        public string  kund= "";
        public string destination = "";
        public int dagar = 0;

        public Resa (string k, string d, int a)
        {
            this.kund = k;
            this.destination = d;
            this.dagar = a;
        }
        public string Kund
        {
            get { return kund;  }
        }


    }
}
