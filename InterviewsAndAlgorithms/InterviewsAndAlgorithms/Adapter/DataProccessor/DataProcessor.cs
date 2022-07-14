using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Adapter.DataProccessor
{
    internal class DataProcessor : IDataProccessor
    {
    
       
        public bool DataProccess()
        {
            Console.WriteLine("Processed data");
            return true;
        }
        public void SendNetworkRequest(string ip, string apiKey)
        {
            Console.WriteLine("Send netowrk request with IP address that requires API KEY: " + ip);
        }
    }
}
