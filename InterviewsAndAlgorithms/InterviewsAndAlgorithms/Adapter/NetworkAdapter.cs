using InterviewsAndAlgorithms.Adapter.DataProccessor;
using InterviewsAndAlgorithms.Adapter.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Adapter
{
    internal class NetworkAdapter : INetworkClient
    {
        private IDataProccessor _dataProccessor;

        public NetworkAdapter(IDataProccessor dataProccessor)
        {
            _dataProccessor = dataProccessor;
        }

        public void SendRequest(string ipAddress)
        {
            var apikey = "4321";
            _dataProccessor.SendNetworkRequest(ipAddress, apikey);
        }
    }
}
