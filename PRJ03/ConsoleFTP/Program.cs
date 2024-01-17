using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ConsoleFTP
{
    class Program
    {
        private static string _address;
        private static string _username;
        private static string _password;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            File.Delete("./../../tractats/RAREDI_44_OK.edi");

            ReadXML();

            Connect();

            SearchAndSaveFile();

            Console.ReadKey();

        }

        private static void ExtractFileData(string fileName)
        {
            try
            {
                string filePath = $"./../../FILES/{fileName}";
                string content = File.ReadAllText(filePath);

                string[] lines = content.Split('\n');
                foreach (string line in lines)
                {
                    string[] fields = line.Split('|');

                    if (fields.Length > 1 && fields[0].Trim() == "LIN")
                    {
                        if (fields.Length > 3)
                        {
                            string longNumber = fields[2].Trim();
                            Console.WriteLine($"Included aircraifts: {longNumber}");
                        }
                    }
                }

                string newFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_OK{Path.GetExtension(fileName)}";
                string newFilePath = $"./../../tractats/{newFileName}";

                Directory.CreateDirectory(Path.GetDirectoryName(newFilePath));

                File.Move(filePath, newFilePath);
                Console.WriteLine("Your file has been analized correctly, it has been send to the 'tractats' folder");
            
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading and extracting LIN numbers: {ex.Message}");
            }
        }

        private static void SearchAndSaveFile()
        {
            Console.WriteLine("Enter the file you want to download (extention included)");
            string fileName = Console.ReadLine().ToString();
            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://{_address}/{fileName}");
                ftpRequest.Credentials = new NetworkCredential(_username, _password);
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

                Stream responseStream = ftpResponse.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string content = reader.ReadToEnd();
                File.WriteAllText($"./../../FILES/{fileName}", content);
                Console.WriteLine($"Download Complete on the 'FILES' folder, status: {ftpResponse.StatusDescription}");

                ExtractFileData(fileName);

                reader.Close();
                ftpResponse.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"FTP Connection Error: {ex.Message}");
            }

        }

        static void Connect()
        {
            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://{_address}");
                ftpRequest.Credentials = new NetworkCredential(_username, _password);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory; 

                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

                Console.WriteLine($"FTP Connected. Status Correct");
                Console.WriteLine($"Connected to: {_address} as {_username}");


                ftpResponse.Close();
            }
            catch (WebException ex)
            {
                Console.WriteLine($"FTP Connection Error: {ex.Message}");
            }
        }

        static void ReadXML()
        {
            string filePath = "./../../Files/credentials.xml"; 

            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ConformanceLevel = ConformanceLevel.Document;
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;
                settings.DtdProcessing = DtdProcessing.Ignore;

                using (XmlReader reader = XmlReader.Create(filePath, settings))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            switch (reader.Name)
                            {
                                case "address":
                                    reader.Read(); 
                                    _address = reader.Value;
                                    break;
                                case "username":
                                    reader.Read();
                                    _username = reader.Value;
                                    break;
                                case "password":
                                    reader.Read();
                                    _password = reader.Value;
                                    break;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
