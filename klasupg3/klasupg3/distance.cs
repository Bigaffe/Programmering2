using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasupg3
{
    class distance
    {
        double _time = 0;
        double _distance = 0;


        public distance(double tid, double distans)
        {
            this._time = tid;
            this._distance = distans;
        }

        public double Time
        {
            get
            {
                return _time;
            }
        }
    }
    

}
