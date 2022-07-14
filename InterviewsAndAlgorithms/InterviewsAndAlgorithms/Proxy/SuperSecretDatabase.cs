using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewsAndAlgorithms.Proxy
{
    internal class SuperSecretDatabase : ISuperSecretDatabase
    {
        private string _databaseName;

        public SuperSecretDatabase(string databaseName)
        {
            _databaseName = databaseName;
        }
        public void DisplayDatabaseName()
        {
            Console.WriteLine("Display database name: " + _databaseName);
        }
    }
}
