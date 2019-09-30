using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klass_5
{
    class Rap
    {


        string _kund = "";
        int _tid = 0;
        public static int antalkunder = 0;

        public Rap(string kund, int tid)
        {
            this._kund = kund;
            this._tid = tid;
            antalkunder++;
        }
        

        public string Kund
        {
            get
            {
                return _kund;
            }
            set
            {
                
                this._kund = value;
            }

        }

        public void ändraKund(string k)
        {
            this._kund = k;
        }

        public int Tid
        {
            get
            {
                return _tid;
            }
        }
    }
}
