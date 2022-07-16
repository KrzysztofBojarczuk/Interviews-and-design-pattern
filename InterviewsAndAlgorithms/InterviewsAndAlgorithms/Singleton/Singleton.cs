using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Singleton
{
    public class Singleton
    {
        static Singleton instance;
        public string Setting { get; set; } = "Color blue";

        public Singleton()
        {
            
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
