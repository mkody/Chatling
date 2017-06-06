// ==== MOTD ========================================================== //
// Salut à toi, petit curieux !                                         //
// Si tu lis ce message, c'est que tu regardes bel-et-bien le code      //
// source de ce programme, et je t'en remercie.                         //
// Je te préviens, tu vas y voir beaucoup de code "spaghetti" par ici.  //
//                                                                      //
// Bon "vomissage" et à la prochaine !                                  //
// ==================================================================== //

// ==== License ======================================================= //
//         DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE                  //
//                    Version 2, December 2004                          //
//                                                                      //
// Copyleft 2014-2016 André Kody Fernandes <im@kdy.ch>                  //
//                                                                      //
// Everyone is permitted to copy and distribute verbatim or modified    //
// copies of this license document, and changing it is allowed as long  //
// as the name is changed.                                              //
//                                                                      //
//            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE               //
//   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION    //
//                                                                      //
//  0. You just DO WHAT THE FUCK YOU WANT TO.                           //
// ==================================================================== //

using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Chatling {
    class Client {
        private readonly string MULTICAST_ADDR = "224.0.0.251";
        private readonly int PORT = 42693; // lol
        public static readonly int PROTOCOL_VERSION = 2;
        private UdpClient udpClient;
        private UdpClient udpListener;
        private UDPState udpState;

        public static Client Instance { get; set; }

        public event EventHandler<MessageEventArgs> MessageReceived;
        public string Handle { get; set; }
        public string TypeMessage { get; set; }
        public bool SaveOnQuitConfig { get; set; }
        public int UserSelectedColor { get; set; }
        public int ClientIP { get; set; }
        public Array Listeners { get; set; }
        public bool Listening { get; set; }

        public Client() {
            Client.Instance = this;
            
            string curIP;
            int indexip = 0;
            do {
                curIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[indexip].ToString();
                ClientIP = IPAddress.Parse(curIP).GetAddressBytes()[3];
                indexip++;
            } while (ClientIP == 0 || ClientIP == 76 || IPAddress.Parse(curIP).GetAddressBytes()[2] == 42 || IPAddress.Parse(curIP).GetAddressBytes()[2] == 43);
            // NOTE : 4th octect is 0 or 76 = probable local loop IPs ; 3rd octect is 42 or 43 = default Android tethering

            Handle = Environment.MachineName;
            UserSelectedColor = 0;
            udpClient = new UdpClient();
            udpClient.JoinMulticastGroup(IPAddress.Parse(MULTICAST_ADDR));
            udpClient.MulticastLoopback = true;
            udpState = new UDPState();
            listen();
        }

        public void Loading() {
            // On lit le fichier de conf' pour récupérer le dernier nom sauvegardé
            FileStream fs = new FileStream(Environment.CurrentDirectory + "\\chatling.conf", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs, ASCIIEncoding.UTF8);
            Handle = Convert.ToString(sr.ReadLine());
            // Mais on filtre ;)
            if (Handle == null || Handle.Contains(" ") || Handle.Contains(" ") || Handle.Length > 10 || Handle.Length < 2) {
                Handle = Environment.MachineName;
            }
            String SaveOnQuitConfigString = sr.ReadLine();
            if (SaveOnQuitConfigString != "True" || SaveOnQuitConfigString != "False") {
                SaveOnQuitConfigString = "True";
            }
            SaveOnQuitConfig = Convert.ToBoolean(SaveOnQuitConfigString);
            try {
                UserSelectedColor = int.Parse(sr.ReadLine());
            } catch (Exception) {
                UserSelectedColor = 0;
            }
            sr.Close();
            fs.Close();
        }

        public void Transmit(string content, string typeMessage) {
            Message msg = new Message();
            msg.ip = ClientIP;
            msg.pv = PROTOCOL_VERSION;
            msg.h = Handle;
            msg.tm = typeMessage;
            msg.cnt = content;
            msg.clr = UserSelectedColor;
            byte[] sendBytes = Encoding.UTF8.GetBytes(msg.ToJson());
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(MULTICAST_ADDR), PORT);
            
            udpClient.BeginSend(sendBytes, sendBytes.Length, endpoint, new AsyncCallback(SendCallback), udpClient);
        }

        private void SendCallback(IAsyncResult ar) {
            UdpClient u = (UdpClient)ar.AsyncState;
            u.EndSend(ar);
        }

        private void listen() {
            IPEndPoint e = new IPEndPoint(IPAddress.Any, PORT);
            udpListener = new UdpClient(e);
            udpState = new UDPState();
            udpState.Endpoint = e;
            udpState.UdpClient = udpListener;
            udpListener.JoinMulticastGroup(IPAddress.Parse(MULTICAST_ADDR));
            udpListener.Ttl = 1;
            udpListener.BeginReceive(new AsyncCallback(ReceiveCallback), udpState);
        }

        private void ReceiveCallback(IAsyncResult ar) {
            udpListener.BeginReceive(new AsyncCallback(ReceiveCallback), udpState);
            UdpClient u = (UdpClient)((UDPState)(ar.AsyncState)).UdpClient;
            IPEndPoint e = (IPEndPoint)((UDPState)(ar.AsyncState)).Endpoint;
            byte[] receiveBytes = u.EndReceive(ar, ref e);
            string receiveString = Encoding.UTF8.GetString(receiveBytes);
            OnMessageRecieved(new MessageEventArgs(receiveString));
        }

        protected virtual void OnMessageRecieved(MessageEventArgs e) {
            if (MessageReceived != null) MessageReceived(this, e);
        }
    }

    class UDPState {
        public IPEndPoint Endpoint { get; set; }
        public UdpClient UdpClient { get; set; }
    }
}