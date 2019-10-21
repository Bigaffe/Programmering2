using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace kap2_upg1
{


    class Titel
    {
        protected string _titel = "";

        public Titel (string titel)
        {
            this._titel = titel;
        }

    }


    class Bok : Titel
    {
        int _sidor;
        

        public Bok (string titel, int sidor) : base(titel)
        {
            this._sidor = sidor;
        }
        
        
        
        public override string ToString()
        {
            if (this._sidor > 1)
            {
                return _titel + ": " + _sidor + " sidor";
            }
            else
            {
                return _titel +": " + _sidor + " sida";
            }

        }
        
    }

    

    class Ljud : Titel
    {
        protected double _tid;

        public Ljud (string titel, double tid) : base(titel)
        {
            this._tid = tid;
        }

        public override string ToString()
        {
            return _titel + ": " + _tid + " minuter";
        }
    }

    class Film : Ljud
    {
        string _upplosning = "";

        public Film (string titel, double tid, string upplosning) : base(titel , tid)
        {
            this._upplosning = upplosning;
        }

        public override string ToString()
        {
            return _titel + ": " + _tid + " minuter " + _upplosning;
        }

    }
}
