using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class FLF : LFactory
    {
        public FLF()
        {
            Console.WriteLine("create FileLogFctory");
        }

        public Logger CreateLogger()
        {
            Logger logger = new FL();
            return logger;
        }
    }
}
