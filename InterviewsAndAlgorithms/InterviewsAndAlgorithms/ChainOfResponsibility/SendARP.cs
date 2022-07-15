using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.ChainOfResponsibility
{
    internal class SendARP : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {

            if (request.Success == false)
            {
                Console.WriteLine("Send ARP failed.");
                if (next != null)
                {

                    next.SendRequest(request);
                }
                else
                {
                    Console.WriteLine("Network transmission failed!!!!  Game over");
                }
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
