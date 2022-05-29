using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penktasPraktinis
{
    class Client
    {
        public static void Send(int port, BigInteger[] keyPub, string message, string signature)
        {
            try
            {
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                TcpClient client = new TcpClient();
                client.Connect(ipEnd);
                var packet = new PacketBuilder();
                packet.WriteMessage(keyPub[0].ToString());
                packet.WriteMessage(keyPub[1].ToString());
                packet.WriteMessage(message);
                packet.WriteMessage(signature);
                client.Client.Send(packet.GetPacket());
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
