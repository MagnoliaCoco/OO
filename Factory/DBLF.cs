using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class DBLF : LFactory
    {
        public DBLF()
        {
            Console.WriteLine("create DBLogFctory");
        }

        public Logger CreateLogger()
        {
            Logger logger = new DBL();
            return logger;
        }
    }
}
