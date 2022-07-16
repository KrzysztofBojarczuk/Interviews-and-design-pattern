using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Strategy
{
    internal class ARP : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Send ARP request!");
        }
    }
}
