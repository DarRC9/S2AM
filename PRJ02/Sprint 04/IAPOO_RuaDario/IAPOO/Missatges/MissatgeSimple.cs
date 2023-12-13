
namespace Missatges
    
{
    /// <summary>
    /// Classe abstracte per no puguer invocarla directament
    /// </summary>
    public abstract class MissatgeSimple
    {
        /// <summary>
        /// Metode simple salutacio sense cap parametre
        /// </summary>
        /// <returns>String generada dins del metode</returns>
        public string salutacio()
        {
            string mis = "Benvingut";
            return mis;
        }
        /// <summary>
        /// Metode heredat de salutacio que rep un parametre
        /// </summary>
        /// <param name="nom">Parametre que dona l'usuari amb el seu nom</param>
        /// <returns>String creada apartir del parametre i una strin propia</returns>
        public string salutacio(string nom)
        {
            string mis = "Benvingut " + nom;
            return mis;
        }
        /// <summary>
        /// Metode simple de comiat sense parametres
        /// </summary>
        /// <returns>String creada dins del metode</returns>
        public virtual string comiat()
        {
            string mis = "Adeu, fins aviat";
            return mis;
        }
    }
}
