using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Assignment7_1_Chat
{
    public partial class Form1 : Form
    {
        private Socket sck = null;
        private EndPoint epLocal;
        private EndPoint epRemote;
        private byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //Get own IP
            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();
        }

        private static string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Create local IPEndpoint with the local IPAddressand bind it to the EndPoint
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), int.Parse(textLocalPort.Text));
                sck.Bind(epLocal);
                // Connect to remote IP and port and bind the remote IPAddress to the remote EndPoint
                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp.Text), int.Parse(textFriendsPort.Text));
                sck.Connect(epRemote);
                //Create a buffer that will be used to recieve messages from the socket and start to listen to a specific port
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                //Change GUI to enable messages to send.
                buttonSend.Enabled = true;
                buttonStart.Text = "Connected";
                buttonStart.Enabled = false;
                textMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
