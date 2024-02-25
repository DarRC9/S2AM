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

namespace TCPClient
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        private int pingTrys = 0;
        private IPEndPoint _ipEndPoint;
        private IPAddress _ipAddress;
        private string _serverName;
        private int _portNumber;
        private TcpClient _tcpClient;
        private bool _isConnected = false;
        private bool _networkAvailability = false;

        private void FillConsole(string status)
        {
            lbx_console.Items.Add(status);
        }

        delegate void ThreadDel(string status);
        private void CheckConnection()
        {
            pnl_status.BackColor = Color.Yellow;
            
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    while (pingTrys < 10)
                    {
                        pingTrys++;
                        Ping serverPing = new Ping();
                        PingReply reply = serverPing.Send(_ipAddress, _portNumber);
                        lbx_console.ForeColor = Color.Purple;
                        if (reply.Address != null)
                        {
                            string status = (reply.Status.ToString() == "Success") ? "OK" : "NOK";
                            if (lbx_console.InvokeRequired)
                            {
                                ThreadDel d = new ThreadDel(FillConsole);
                                this.Invoke(d, new object[] { "Ping " + pingTrys + " - " + status });
                            }
                            else
                            {
                                lbx_console.Items.Add("Ping " + pingTrys + " - " + status);
                            }
                            _networkAvailability = true;
                        }
                    }
                    //for (int i = 0; i < 10; i++)
                    //{
                        
                    //} 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when pinging server: " + ex.Message);
                }
            } else
            {
            }
        }

        private void OpenCredentials()
        {
            try
            {
                XDocument doc = XDocument.Load("./../../ServerCredentials/TCPSettings.xml");

                XElement tcpElement = doc.Descendants("TCP").FirstOrDefault();
                if (tcpElement != null)
                {
                    txb_ip.Text = tcpElement.Element("IP")?.Value;
                    txb_port.Text = tcpElement.Element("Port")?.Value;
                } else {
                    MessageBox.Show("TCP credential not found inside XML file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when accesing XML: " + ex.Message);
            }
        }

        private void UpdateCredentials()
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

        private void SendMessage()
        {
            _tcpClient = new TcpClient(_ipEndPoint);

            Byte[] dades = Encoding.ASCII.GetBytes(txb_message.Text);
            NetworkStream ns = _tcpClient.GetStream();

            ns.Write(dades, 0, dades.Length);
        }

        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            _ipAddress = IPAddress.Parse(txb_ip.Text);
            _portNumber = int.Parse(txb_port.Text);

            Thread checkConnectionThread = new Thread(CheckConnection);
            checkConnectionThread.Start();
            //MessageBox.Show(_networkAvailability.ToString());
            bool hasConection = _networkAvailability;
            MessageBox.Show(hasConection.ToString());

            if (hasConection)
            {
                pnl_status.BackColor = Color.Green;
                OpenCredentials();
            } else
            {
                pnl_status.BackColor = Color.Red;
            }
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txb_ip.Text) && !string.IsNullOrWhiteSpace(txb_port.Text))
            {
                UpdateCredentials();
            } else
            {
                MessageBox.Show("Can't update credential with empty values");
            }
        }
    }

    //TcpListener Listener = new TcpListener(_ipAddress, _portNumber);
    //Listener.Start();
    //_isConnected = true;

    //while (_isConnected)
    //{
    //    if (Listener.Pending())
    //    {
    //        TcpClient client =
    //        Listener.AcceptTcpClient();
    //        NetworkStream ns = client.GetStream();
    //        byte[] buffer = new byte[1024];
    //        ns.Read(buffer, 0, buffer.Length);
    //    }
    //}
}
