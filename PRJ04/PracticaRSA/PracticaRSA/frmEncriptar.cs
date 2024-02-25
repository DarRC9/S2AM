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
    public partial class frmEncriptar : Form
    {
        public frmEncriptar()
        {
            InitializeComponent();
        }

        private string _publicKeyPath;
        private string _publicKey;
        private byte[] _encryptedData;
        private string _visibleEncryptedData;

        private void btn_obtainKey_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                openFileDialog.InitialDirectory = @"C:\";
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    _publicKeyPath = openFileDialog.FileName;
                }
            }
            _publicKey = File.ReadAllText(_publicKeyPath);
        }

        private void EncryptMessage()
        {
            RSACryptoServiceProvider rsaEncrypt = new RSACryptoServiceProvider();
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            rsaEncrypt.FromXmlString(_publicKey);

            byte[] dataToEncrypt = ByteConverter.GetBytes(tbx_original.Text);
            _encryptedData = rsaEncrypt.Encrypt(dataToEncrypt, false);
            _visibleEncryptedData = ByteConverter.GetString(_encryptedData);

            tbx_crypted.Text = _visibleEncryptedData;
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            EncryptMessage();
        }

        private void btn_showKey_Click(object sender, EventArgs e)
        {
            tbx_pubkey.Text = _publicKey;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is frmDesencriptar frm)
                    {
                        frm.EncryptedData = _encryptedData;
                        frm.VisibleEncryptedData = _visibleEncryptedData;

                        frm.BringToFront();
                        break;
                    }
                    else
                    {
                        frmDesencriptar frmDecrypt = new frmDesencriptar();
                        frmDecrypt.EncryptedData = _encryptedData;
                        frmDecrypt.VisibleEncryptedData = _visibleEncryptedData;

                        frmDecrypt.Show();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error when finding Decrypt form: ", ex.Message);
            }
        }
    }
}
