using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missatges
{
    
    public class MissatgeHeredat : MissatgeSimple
    {
        /// <summary>
        /// Metodo sss
        /// </summary>
        /// <param name="nom">aporta nmmbre</param>
        /// <param name="bandol">aporta bandol</param>
        /// <returns></returns>
        public string salutacio(string nom, string bandol)
        {
            string mis = nom + " , benvingut a la " + bandol;
            return mis;
        }

        public override string comiat()
        {
            return "Goodbye";
        }

        public string comiatCatala()
        {
            return base.comiat();
        }
    }
}
