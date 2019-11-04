using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal
{
    class Personal
    {
        protected string namn = "";

        public Personal ( string namn)
        {
            this.namn = namn;
        }

        public virtual double calcSalary()
        {
            return 0;
        }
    }
}
