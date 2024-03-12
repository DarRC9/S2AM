using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;
using System.IO;
using System.Threading;
using System.IO.Compression;

namespace FileGenerator
{
    public partial class FileGenerator : Form
    {
        public FileGenerator()
        {
            InitializeComponent();
        }

        class LetterCode
        {
            public string letter;
            public string code;
        }

        #region Configuration

        private string _folderPath = @".\Files\";
        private int _fileNumber, _letterNumber;
        readonly List<string> _vowels = new List<string> { "A", "E", "I", "O", "U" };
        private ArrayList _numberList;
        private List<LetterCode> _codificationLetters = new List<LetterCode>();

        #endregion

        #region Threads

        private Thread _fileGenerator;
        private Thread _fileZipper;

        #endregion

        #region Methods
        public static string GetRandomVowels(int letterNumber)
        {
            char[] chars = "AEIOU".ToCharArray();
            byte[] data = new byte[letterNumber];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(10);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        private Queue<int> CreateRandomNumberList()
        {
            Queue<int> codeQueue = new Queue<int>();

            while (_numberList.Count > 0)
            {
                RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                var byteArray = new byte[4];
                provider.GetBytes(byteArray);
                var randomInteger = BitConverter.ToInt32(byteArray, 0);

                Random rand = new Random(randomInteger);
                int index = rand.Next(0, _numberList.Count);
                codeQueue.Enqueue(Convert.ToInt32(_numberList[index]));
                _numberList.RemoveAt(index);
            }
            return codeQueue;
        }

        private void WriteCodification()
        {
            FileStream condificationFile = new FileStream("C:.\\..\\..\\codification.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(condificationFile);

            foreach (LetterCode letterCode in _codificationLetters)
            {
                writer.Write($"{letterCode.letter}:{letterCode.code}\n");
            }
            writer.Close();
        }

        private string GetLetterCode(Queue<int> numbersQueue)
        {
            string code = "";
            while (numbersQueue.Count > 0)
            {
                code += numbersQueue.Dequeue().ToString();
            }
            return code;
        }

        private void FillNumberList()
        {
            _numberList = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                _numberList.Add(i);
            }
        }

        private void FileGenerator_Load(object sender, EventArgs e)
        {
            FillNumberList();
        }

        private string GetVowelCode(string vowel)
        {
            LetterCode vowelCode = new LetterCode();
            if (!string.IsNullOrWhiteSpace(vowel)){
                vowelCode = _codificationLetters.Find(c => c.letter == vowel);
            }
            return vowelCode.code;
        }
        private void CleanFolder()
        {
            if (Directory.Exists(_folderPath))
            {
                foreach (string filePath in Directory.GetFiles(_folderPath))
                {
                    File.Delete(filePath);
                }
            } else
            {
                Directory.CreateDirectory(_folderPath);
            }
        }

        private void GenerateUniqueFileEncode()
        {
            CleanFolder();
 
            Parallel.For(1, _fileNumber+1, (fileInstance) =>
            {
                string filePath = $".\\Files\\fitxer_{fileInstance}.txt";
                using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
                {
                    using (StreamWriter writer = new StreamWriter(file))
                    {
                        string randomVowelCode = GetRandomVowels(_letterNumber);
                        writer.Write(randomVowelCode + "\n");
                    }
                }
            });
            AppendVowelCodes();
        }

        private void AppendVowelCodes()
        {
            Parallel.For(1, _fileNumber + 1, (fileInstance) =>
            {
                string filePath = $".\\Files\\fitxer_{fileInstance}.txt";
                FileStream fileRead = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read);
                FileStream fileReadAndWrite = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                StreamReader fileReader = new StreamReader(fileReadAndWrite);
                
                string vowelCode = fileReader.ReadToEnd();

                StreamWriter fileWriter = new StreamWriter(fileRead);
                foreach (char vowel in vowelCode)
                {
                    string code = GetVowelCode(vowel.ToString());
                    fileWriter.Write(code);
                    fileWriter.Flush();
                }
                fileReader.Close();
                fileWriter.Close();
            });           
        }

        private void GenerateFilesZip()
        {
            _fileGenerator.Join();
            string zipFilePath = $"{_folderPath}\\Files.zip";
            string[] encodedFiles = Directory.GetFiles(_folderPath);
            using (ZipArchive archive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
            {
                foreach (string file in encodedFiles)
                {
                    archive.CreateEntryFromFile(file, Path.GetFileName(file));
                }
            }
        }
        #endregion

        #region Events
        private void btn_GenerateFiles_Click(object sender, EventArgs e)
        {
            _fileNumber = int.Parse(txb_FilesNumber.Text);
            _letterNumber = int.Parse(txb_LettersNumber.Text);

            _fileZipper = new Thread(GenerateFilesZip);
            _fileGenerator = new Thread(GenerateUniqueFileEncode);

            _fileZipper.Start();
            _fileGenerator.Start();
        }

        private void btn_GenerateCodification_Click(object sender, EventArgs e)
        {
            foreach (string vowel in _vowels)
            {
                LetterCode existingCode = _codificationLetters.Find(c => c.letter == vowel);

                if (existingCode == null)
                {
                    Queue<int> codeQueue = CreateRandomNumberList();
                    string code = GetLetterCode(codeQueue);
                    _codificationLetters.Add(new LetterCode { letter = vowel, code = code });
                }
                else
                {
                    Queue<int> codeQueue = CreateRandomNumberList();
                    string code = GetLetterCode(codeQueue);
                    existingCode.code = code;
                }
                FillNumberList();
            }
            WriteCodification();
        }
        #endregion
    }
}
