using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banken
{
    class Bank
    {
        public string personNr;
        public double rantesats;
        public double kredit;

        public Bank (string personNr, double rantesats, double kredit)
        {
            this.personNr = personNr;
            this.rantesats = rantesats;
            this.kredit = kredit;
        }

        /*public override string ToString()
        {
            if (this.kredit != 0)
            {
                return "Lånekonto" + personNr + ". " + 0;
            }
            else
            {

            }
            
        }
        */
        

    }
}
