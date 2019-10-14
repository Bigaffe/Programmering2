using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovn1._5
{
    class Fordon
    {
        string regNr;
        string marke ;
        string modell;
         public enum FordonsTyp { Bilar, MC, ickevald};
        FordonsTyp fordonsTyp = FordonsTyp.ickevald;

        public Fordon (string registeringsnummer, string fordonsmarke, string arsmodell, FordonsTyp bilMC)
        {
            this.regNr = registeringsnummer;
            this.marke =  fordonsmarke;
            this.modell = arsmodell;
            this.fordonsTyp = bilMC;
        }

        public FordonsTyp fordonstypen
        {
            get
            {
                return fordonsTyp;
            }
            set
            {

                this.fordonsTyp = value;
            }

        }


    }
}
