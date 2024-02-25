using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRSA
{
    public partial class frmDesencriptar : Form
    {
        public frmDesencriptar()
        {
            InitializeComponent();
        }
        public byte[] EncryptedData
        {
            get { return _encryptedData; }
            set { _encryptedData = value; }
        }

        public string VisibleEncryptedData
        {
            get { return _visibleEncryptedData; }
            set 
            { 
                _visibleEncryptedData = value;
                tbx_crypted.Text = _visibleEncryptedData; 
            }
        }

        private string _visibleEncryptedData;
        private string _visibleDecryptedData;
        private byte[] _encryptedData;
        private byte[] _decryptedData;
        private string _keyContainerName;
        private string _directoryXmlPath;
        private void btn_generate_Click(object sender, EventArgs e)
        {
            _keyContainerName = tbx_container.Text;
            _directoryXmlPath = tbx_routeXML.Text;
            try
            {
                CreateKeyPair();
                MessageBox.Show("Key pair created succesfully!");
            } catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void CreateKeyPair()
        {
            CspParameters cspp = new CspParameters();
            cspp.KeyContainerName = _keyContainerName;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            string publicKey = rsa.ToXmlString(false);
            File.WriteAllText(_directoryXmlPath + "\\PublicKey.xml", publicKey);
        }

        private void btn_routeXML_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.SelectedPath = @"C:\";
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        tbx_routeXML.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error when selecting path: ", ex.Message);
            }
            
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            _keyContainerName = tbx_container.Text;
            CspParameters cspp = new CspParameters();
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            cspp.KeyContainerName = _keyContainerName;

            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
                _decryptedData = rsa.Decrypt(_encryptedData, false);

                _visibleDecryptedData = ByteConverter.GetString(_decryptedData);
                tbx_decrypted.Text = _visibleDecryptedData;
            } catch (Exception ex)
            {
                MessageBox.Show("Error when decrypting data: ", ex.Message);
            }
            
        }
    }   
}
