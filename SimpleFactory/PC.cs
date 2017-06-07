using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class PC : Chart
    {
        public PC()
        {
            Console.WriteLine("create PC");
        }

        public void Display()
        {
            Console.WriteLine("display PC");
        }
    }
}
