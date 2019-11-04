using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal
{
    class Saljare : Personal
    {
        double provisionen = 0;
        double forsaljning = 0;

        public Saljare (string namn, double provisionen, double forsaljning) : base(namn)
        {
            this.namn = namn;
            this.provisionen = provisionen;
            this.forsaljning = forsaljning;
        }

        public override double calcSalary()
        {
            double pengar = provisionen * forsaljning;
            return pengar;
        }

    }
}
