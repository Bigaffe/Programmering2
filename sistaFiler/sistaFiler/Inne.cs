using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistaFiler
{
    class Inne
    {
        string namn;
        double mangd;
        string matt;

        public Inne(string namn, double mangd, string matt)
        {
            this.namn = namn;
            this.mangd = mangd;
            this.matt = matt;
        }

        public string Namn
        {
            get
            {
                return namn;
            }
        }
        public double Mangd
        {
            get
            {
                return mangd;
            }
        }
        public string Matt
        {
            get
            {
                return matt;
            }
        }




    }
}
