using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class LC : Chart
    {
        public LC()
        {
            Console.WriteLine("create LC");
        }

        public void Display()
        {
            Console.WriteLine("display LC");
        }
    }
}
