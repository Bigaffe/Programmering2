using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slutprogrammering
{
    /// <summary>
    /// Huvud objekt
    /// </summary>
    class Kort
    {
        /// <summary>
        /// Placeringen i x led
        /// </summary>
        private int _xposition = 0;
        /// <summary>
        /// Placering i y led
        /// </summary>
        private int _yposition = 0;
        /// <summary>
        /// Kortets figur (nummer)
        /// </summary>
        private int _figur = 0;

        //Tänkte använda mig av enum istället för int på figuren, men för att jag skulle behöva ha ett stort antal figurer så tog jag bort det, sedan hade jag lite problem med det i början vilket stärkte mitt val mer.
                

        public Kort(int horisent, int vertikal, int figur)
        {
            this._xposition = horisent;
            this._yposition = vertikal;
            this._figur = figur;
        }

        /// <summary>
        /// Hämtar _xposition ifall xposition nämns. Samma med figuren och yposition
        /// </summary>
        public int xposition
        {
            get
            {
                return _xposition;
            }
        }
        public int yposition
        {
            get
            {
                return _yposition;
            }
        }

        public int figuren
        {
            get
            {
                return _figur;
            }
            set
            {
                _figur = value;
            }
        }

    }

    

    
}
