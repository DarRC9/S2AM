using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using System.IO;

namespace TCPClient
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private NetworkStream _networkStream;
        private IPAddress _ipAddress;
        private int _portNumber;
        private TcpClient _tcpClient;
        private bool _isConnected = false;

        private Thread checkConnectionThread;
        private Thread sendMessageThread;
        private delegate void UpdateUI(string status);
        private delegate void UpdateUIWithoutParam();

        //
        private Thread sendFileThread;
        private string _sendingFilePath = "";
        private const int BufferSize = 1024;


        private void FillConsole(string status)
        {
            if (lbx_console.InvokeRequired)
            {
                UpdateUI updateUI = FillConsole;
                BeginInvoke(updateUI, status);
            }
            else
            {
                lbx_console.Items.Add(status);
            }
        }

        private void OpenCredentials()
        {
            if (txb_ip.InvokeRequired && txb_message.InvokeRequired)
            {
                UpdateUIWithoutParam updateUI = OpenCredentials;
                BeginInvoke(updateUI);
            }
            else
            {
                try
                {
                    XDocument doc = XDocument.Load("./../../ServerCredentials/TCPSettings.xml");

                    XElement tcpElement = doc.Descendants("TCP").FirstOrDefault();
                    if (tcpElement != null)
                    {
                        txb_ip.Text = tcpElement.Element("IP")?.Value;
                        txb_port.Text = tcpElement.Element("Port")?.Value;
                        txb_ipA.Text = tcpElement.Element("IP")?.Value;
                        txb_portA.Text = tcpElement.Element("Port")?.Value;
                    }
                    else
                    {
                        MessageBox.Show("TCP credential not found inside XML file");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when accessing XML: " + ex.Message);
                }
            }
        }

        private void UpdateCredentials()
        {
            if (txb_ip.InvokeRequired && txb_message.InvokeRequired)
            {
                UpdateUIWithoutParam updateUI = OpenCredentials;
                BeginInvoke(updateUI);
            }
            else
            {
                try
                {
                    XDocument doc = XDocument.Load("./../../ServerCredentials/TCPSettings.xml");

                    XElement tcpElement = doc.Descendants("TCP").FirstOrDefault();
                    if (tcpElement != null)
                    {
                        tcpElement.Element("IP").Value = txb_ip.Text;
                        tcpElement.Element("Port").Value = txb_port.Text;
                    }
                    else
                    {
                        MessageBox.Show("TCP credential not found inside XML file");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when accesing XML: " + ex.Message);
                }
            }
        }

        private void SendMessage()
        {
            if (!string.IsNullOrWhiteSpace(txb_message.Text))
            {
                _tcpClient = new TcpClient(_ipAddress.ToString(), _portNumber);

                Byte[] message = Encoding.ASCII.GetBytes(txb_message.Text);
                _networkStream = _tcpClient.GetStream();

                _networkStream.Write(message, 0, message.Length);
            }
            else
            {
                MessageBox.Show("Can't send empty message to the server");
            }
            _networkStream.Close();
        }

        private void CheckConnection()
        {
            pnl_status.BackColor = Color.Yellow;
            
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Ping serverPing = new Ping();
                        PingReply reply = serverPing.Send(_ipAddress, _portNumber);
                        lbx_console.ForeColor = Color.LightPink;
                        if (reply.Address != null)
                        {
                            string status = (reply.Status.ToString() == "Success") ? "OK" : "NOK";
                            FillConsole("Ping " + (i + 1) + " - " + status);
                            Thread.Sleep(500);
                            _isConnected = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when pinging server: " + ex.Message);
                }
            }
            if (_isConnected)
            {
                pnl_status.BackColor = Color.Green;
                OpenCredentials();
            }
            else
            {
                pnl_status.BackColor = Color.Red;
            }
        }

        private void ChangeStatus(string statusMessage)
        {
            if (lbl_Status.InvokeRequired)
            {
                UpdateUI updateUI = ChangeStatus;
                BeginInvoke(updateUI, statusMessage);
            }
            else
            {
                lbl_Status.Text = statusMessage;
            }
        }

        private void SendTCP()
        {
            byte[] SendingBuffer = null;
            try
            {
                _tcpClient = new TcpClient(_ipAddress.ToString(), _portNumber);
                ChangeStatus("Connected to the Server...\n");
                _networkStream = _tcpClient.GetStream();
                FileStream Fs = new FileStream(_sendingFilePath, FileMode.Open, FileAccess.Read);
                int NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));
                int TotalLength = (int)Fs.Length, CurrentPacketLength, counter = 0;
                for (int i = 0; i < NoOfPackets; i++)
                {
                    if (TotalLength > BufferSize)
                    {
                        CurrentPacketLength = BufferSize;
                        TotalLength = TotalLength - CurrentPacketLength;
                    }
                    else
                        CurrentPacketLength = TotalLength;
                    SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                    _networkStream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                }
                ChangeStatus(lbl_Status.Text + "Sent " + Fs.Length.ToString() + "bytes to the server");
                Fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when triying to send message: " + ex.Message);
            }
        }

        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            _ipAddress = IPAddress.Parse(txb_ip.Text);
            _portNumber = int.Parse(txb_port.Text);
            checkConnectionThread = new Thread(CheckConnection);

            checkConnectionThread.Start();
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            _ipAddress = IPAddress.Parse(txb_ip.Text);
            _portNumber = int.Parse(txb_port.Text);
            sendMessageThread = new Thread(SendMessage);
            sendMessageThread.Start();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txb_ip.Text) && !string.IsNullOrWhiteSpace(txb_port.Text))
            {
                UpdateCredentials();
            } else
            {
                MessageBox.Show("Can't update credentials with empty values");
            }
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            checkConnectionThread.Abort();
            _networkStream.Close();
            _tcpClient.Close();
            MessageBox.Show("You have disconnected from the server");
        }

        private void btn_browseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "All Files (*.*)|*.*";
            Dlg.CheckFileExists = true;
            Dlg.Title = "Choose a File";
            Dlg.InitialDirectory = @"C:\";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                _sendingFilePath = Dlg.FileName;

            }
        }
            
        private void btn_sendFile_Click(object sender, EventArgs e)
        {
            if (_sendingFilePath != "")
            {
                _ipAddress = IPAddress.Parse(txb_ipA.Text);
                _portNumber = int.Parse(txb_portA.Text);
                sendFileThread = new Thread(SendTCP);
                sendFileThread.Start();
  
            }
            else
                MessageBox.Show("Select a file", "Warning");
        }

    }
}
