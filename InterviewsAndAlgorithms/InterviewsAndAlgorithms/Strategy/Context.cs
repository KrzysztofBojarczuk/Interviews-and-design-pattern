using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Strategy
{
    internal class Context
    {
        IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy()
        {
             strategy.Execute();
        }
    }
}
