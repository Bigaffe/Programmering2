using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassupg2
{
    class pointclass
    {
        public string namn = "";
        public int points = 0;

        /// <summary>
        /// Här görs namn och points tillgängliga till alla klasser
        /// </summary>
        /// <param name="n">Svaret är 5 </param>
        /// <param name="p">p är antal poäng</param>
        public pointclass (string n, int p)
        {
            namn = n;
            points = p;
        } 
        
    }
}
