using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.ChainOfResponsibility
{
    internal class SendSSH : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send SSH failed. Sending PING");

                if (next != null)
                {

                    next.SendRequest(request);
                }
                else
                {
                    Console.WriteLine("Network transmission failed!!!! Terminating");
                }
            }
            else
            {
                Console.WriteLine("Send SSH success");
            }
        }


        public void SetNext(IChain nextChain)
        {
            this.next = nextChain;
        }
    }
}
