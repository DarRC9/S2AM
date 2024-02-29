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

        List<string> _vowels = new List<string> { "A", "E", "I", "O", "U" };
        private ArrayList _numberList;
        private List<LetterCode> codificationLetters = new List<LetterCode>();


        private void btn_GenerateCodification_Click(object sender, EventArgs e)
        {
            foreach (string vowel in _vowels)
            {
                string code = "";
                while (_numberList.Count > 0)
                {
                    RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                    var byteArray = new byte[4];
                    provider.GetBytes(byteArray);
                    var randomInteger = BitConverter.ToInt32(byteArray, 0);

                    Random rand = new Random(randomInteger);
                    int index = rand.Next(0, _numberList.Count);
                    code += _numberList[index];
                    _numberList.RemoveAt(index);
                }
                MessageBox.Show(code);

                codificationLetters.Add(new LetterCode { letter = vowel, code = code });
                FillNumberList();
            }
            //foreach (LetterCode letter in codificationLetters)
            //{
            //    MessageBox.Show(letter.letter + " " + letter.code);
            //}
        }

        private void btn_GenerateFiles_Click(object sender, EventArgs e)
        {

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
    }
}
