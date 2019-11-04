using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal
{
    class Konsult : Personal
    {
        double hoursalary = 0;
        double worktime = 0;
        
        public Konsult(string namn, double hoursalary, double worktime):base(namn)
        {
            this.namn = namn;
            this.hoursalary = hoursalary;
            this.worktime = worktime;
            
        }

        

        public override double calcSalary()
        {
            double pengar = hoursalary * worktime;
            return pengar;
        }

    }
}
