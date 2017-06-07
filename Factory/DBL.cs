using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class DBL : Logger
    {
        public void WriteLog()
        {
            Console.WriteLine("log DB");
        }
    }
}
