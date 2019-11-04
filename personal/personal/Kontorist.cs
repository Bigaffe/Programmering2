using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal
{
    class Kontorist : Personal
    {

        double _lon = 0;

        public Kontorist(string namn, double lon) : base(namn)
        {
            this.namn = namn;
            this._lon = lon;
        }

        public override double calcSalary()
        {
            double pengar = _lon;
            return pengar;
        }
    }
}
