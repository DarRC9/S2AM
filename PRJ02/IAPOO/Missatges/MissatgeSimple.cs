namespace Missatges
{
    public abstract class MissatgeSimple
    {
        public string salutacio()
        {
            string mis = "Benvingut";
            return mis;
        }

        public string salutacio(string nom)
        {
            string mis = "Benvingut, " + nom;
            return mis;
        }

        public virtual string comiat()
        {
            string mis = "Adeu, fins aviat";
            return mis;
        }
    }
}
