using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PracticaTCP
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        private int _portNumber;
        private bool _isConnected = false;
        private Thread serverListener;

        private const int BufferSize = 1024;
        public string Status = string.Empty;
        public Thread serverFileListener;

        private delegate void UpdateUI(string status);

        private void Connect()
        {
            try
            {
                TcpListener Listener = new TcpListener(IPAddress.Any, _portNumber);

                Listener.Start();
                _isConnected = true;

                while (_isConnected)
                {
                    if (Listener.Pending())
                    {
                        TcpClient client = Listener.AcceptTcpClient();
                        NetworkStream ns = client.GetStream();
                        byte[] buffer = new byte[1024];
                        int bytesRead = ns.Read(buffer, 0, buffer.Length);
                        string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                        PrintMessages(receivedMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when triying to listen:" + ex.Message);
            }
        }

        private string OpenSaveFileDialog()
        {
            string saveFileName = "";

            if (InvokeRequired)
            {
                // If not on the UI thread, invoke the method on the UI thread
                Invoke(new MethodInvoker(delegate
                {
                    saveFileName = OpenSaveFileDialog();
                }));
            }
            else
            {
                SaveFileDialog dialogSave = new SaveFileDialog();
                dialogSave.Filter = "All files (*.*)|*.*";
                dialogSave.RestoreDirectory = true;
                dialogSave.Title = "Where do you want to save the file?";
                dialogSave.InitialDirectory = @"C:/";

                if (dialogSave.ShowDialog() == DialogResult.OK)
                {
                    saveFileName = dialogSave.FileName;
                }
            }

            return saveFileName;
        }

        public void ReceiveTCP()
        {
            TcpListener Listener = null;
            try
            {
                Listener = new TcpListener(IPAddress.Any, _portNumber);
                Listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            byte[] RecData = new byte[BufferSize];
            int RecBytes;

            for (; ; )
            {
                TcpClient client = null;
                NetworkStream netstream = null;
                Status = string.Empty;
                try
                {
                    string message = "Accept the Incoming File ";
                    string caption = "Incoming Connection";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();
                        Status = "Connected to a client\n";
                        result = MessageBox.Show(message, caption, buttons);

                        if (result == DialogResult.Yes)
                        {
                            string saveFileName = OpenSaveFileDialog();
                            if (!string.IsNullOrEmpty(saveFileName))
                            {
                                using (StreamWriter writer = new StreamWriter(saveFileName, false))
                                {
                                    using (StreamReader reader = new StreamReader(netstream, Encoding.UTF8))
                                    {
                                        string line;
                                        while ((line = reader.ReadLine()) != null)
                                        {
                                            writer.WriteLine(line);
                                        }
                                    }
                                }
                            }
                            netstream.Close();
                            client.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //netstream.Close();
                }
            }
        }
        private void PrintMessages(string message)
        {
            if (lbx_Missatges.InvokeRequired)
            {
                Invoke(new Action<string>(PrintMessages), message);
                return;
            }

            lbx_Missatges.Items.Add(message);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            _portNumber = int.Parse(txb_port.Text);
            serverListener = new Thread(Connect);

            serverListener.Start();
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            serverListener.Abort();
            MessageBox.Show("You stopped listening to the server");
        }

        private void btn_FileListener_Click(object sender, EventArgs e)
        {
            _portNumber = int.Parse(txb_port.Text);
            serverFileListener = new Thread(ReceiveTCP);
            serverFileListener.IsBackground = true;

            serverFileListener.Start();
        }
    }
}
