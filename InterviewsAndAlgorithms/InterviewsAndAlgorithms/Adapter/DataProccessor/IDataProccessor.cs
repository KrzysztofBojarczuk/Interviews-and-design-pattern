using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Adapter.DataProccessor
{
    internal interface IDataProccessor
    {
        bool DataProccess();
        void SendNetworkRequest(string ip, string apiKey);
    }
}
