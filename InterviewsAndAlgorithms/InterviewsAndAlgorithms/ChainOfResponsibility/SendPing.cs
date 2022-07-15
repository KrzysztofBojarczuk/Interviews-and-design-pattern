using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.ChainOfResponsibility
{
    internal class SendPing : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            

            if (request.Success == false)
            {
                Console.WriteLine("Send Ping failed. Sending ASP");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send Ping success");
            }
        }

        public void SetNext(IChain nextChain)
        {
            this.next = nextChain;
        }
    }
}
