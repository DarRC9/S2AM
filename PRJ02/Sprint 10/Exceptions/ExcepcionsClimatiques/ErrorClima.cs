using System;

namespace ExcepcionsClimatiques
{
    public class ErrorClima : ApplicationException
    {
        private string message, action;
        public ErrorClima(string messa, string ex)
        {
            message = messa;
            action = ex;
        }
        public override string Message
        {
            get
            {
                return string.Format(
                    "Incidencia climatica:\n" +
                    "Incidencia critica: " + message + "\n" +
                    "Operativa d'actuació: " + action);
            }
        }
    }
}
