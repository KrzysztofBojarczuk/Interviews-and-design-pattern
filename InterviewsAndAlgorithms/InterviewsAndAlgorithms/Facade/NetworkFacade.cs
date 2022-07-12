using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Facade
{
    internal class NetworkFacade
    {
        private Packet packet;
        private Socket socket;
        private Transmission transmission;

      
        public NetworkFacade(string ip,string protocol)
        {
            packet = new Packet(ip);
            socket = new Socket(protocol);
            transmission = new Transmission(protocol);
        }
        public void BuildNetworkLayer()
        {
            packet.PacketBuilt();
            socket.BuildSocket();
          
        }
        public void SendPAcketOverNetwork()
        {
            BuildNetworkLayer();
            transmission.SendTransmission();
        }
    }
}
