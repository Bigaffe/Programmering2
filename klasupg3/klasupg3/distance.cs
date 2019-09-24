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
        double _speed = 0;


        public distance(double tid, double distans, double speed)
        {
            this._time = tid;
            this._distance = distans;
            this._speed = speed;
        }

        public double Time
        {
            get
            {
                return _time;
            }
        }
        public double Distance
        {
            get
            {
                return _distance;
            }
        }
        public double SPEED
        {
            get
            {
                return _speed;
            }
        }
    }
    

}
