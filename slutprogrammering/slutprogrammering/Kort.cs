using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slutprogrammering
{
    class Kort
    {
        private int _xposition = 0;
        private int _yposition = 0;
        private string _figur = "";

        public Kort(int horisent, int vertikal, string bild)
        {
            this._xposition = horisent;
            this._yposition = vertikal;
            this._figur = bild;
        }

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
        public string figur
        {
            get
            {
                return _figur;
            }
        }
    }

    
}
