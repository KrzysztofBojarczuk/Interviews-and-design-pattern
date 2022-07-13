using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Adapter.Network
{
    public class NetworkClient : INetworkClient
    {
        public  void SendRequest(string ipAddress)
        {
            Console.WriteLine("Sending client request sent to IP: " + ipAddress);
        }

    }
}
