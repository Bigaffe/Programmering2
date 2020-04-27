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
        //private string _figur = "";
        public enum _bilder
        {
            ingen = 0,
            elefant = 1,
            älg = 2,
            katt = 3,
            hund = 4,
            fisk = 5,
            fiskmås = 6,
            orm = 7,
            ödla = 8,
            varg = 9,
            lejon = 10,
        }
        private int _figur = 0;
                

        public Kort(int horisent, int vertikal, _bilder figur)
        {
            this._xposition = horisent;
            this._yposition = vertikal;
            this._figur = (int)figur;
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

        public int figuren
        {
            get
            {
                return _figur;
            }
        }
    }

    class AllaFigurer
    {
        private enum bilder
        {
            ingen = 0,
            elefant = 1,
            älg = 2,
            katt = 3,
            hund = 4,
            fisk = 5,
            fiskmås = 6,
            orm = 7,
            ödla = 8,
            varg = 9,
            lejon = 10,


        }
        private string _figur = "";

        public AllaFigurer(string bild)
        {
            this._figur = bild;
        }
        public string bilden
        {
            get
            {
                return _figur;
            }
        }

    }

    
}
