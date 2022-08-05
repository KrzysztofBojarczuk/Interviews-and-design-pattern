using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Delegates
{
    public class DelegateClass
    {
        public int Calc(int num1, int num2)
        {
            return num1 * num2;
        }
        public void Show()
        {
            Console.WriteLine("Delagates are funny");
        }
        
        public bool GraterThenTen(int num)
        {
            return num > 10;
        }
    }
}
