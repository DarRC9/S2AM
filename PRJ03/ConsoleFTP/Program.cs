using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFTP
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("XD");
            Console.ReadKey();
            
        }
        static void Connect()
        {
            string strUser = "g04";
            string strPassword = "12345aA";

            FtpWebRequest ftpRequest;
            ftpRequest = (FtpWebRequest)WebRequest.Create("sqlserver.S2AM.sdslab.cat");
      

            ftpRequest.Credentials = new NetworkCredential(strUser, strPassword);
        }
    }
}
