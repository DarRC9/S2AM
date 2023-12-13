using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Missatges
{
    /// <summary>
    /// Classe que hereda de MissatgeSimple i amplia amb tres metodes més
    /// </summary>
    public class MissatgeHeredat : MissatgeSimple
    {
        /// <summary>
        /// Metode que amb els dos parametres obtinguts creara una frase (string)
        /// </summary>
        /// <param name="nom">Parametre que indica el nom de l'usuari de l'aplicació</param>
        /// <param name="bandol">Parametre que indica el bandol de l'usuari de l'aplicació</param>
        /// <returns>String formada per els parametres i una propia</returns>
     
        public string salutacio(string nom, string bandol)
        {
            string mis = nom + ", benvingut a " + bandol;
            return mis;
        }
        /// <summary>
        /// Metode sense parametres que retorna una string en angles
        /// </summary>
        /// <returns>String inciada en el metode</returns>
        public override string comiat()
        {
            string mis = "Bye, see you later";
            return mis;
        }
        /// <summary>
        /// Metode sense parametres que retorna una string en catala
        /// </summary>
        /// <returns>String inciada en el metode</returns>
        public string comiatCatala()
        {
            string mis = base.comiat();
            return mis;
        }
    }
}
