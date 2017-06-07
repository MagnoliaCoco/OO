using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class CFactory
    {
        public static Chart GetChart(string type)
        {
            Chart chart = null;

            if (type.Equals("H"))
            {
                chart = new HC();
                Console.WriteLine("init HC");
            }

            if (type.Equals("P"))
            {
                chart = new HC();
                Console.WriteLine("init PC");
            }

            if (type.Equals("L"))
            {
                chart = new HC();
                Console.WriteLine("init LC");
            }

            return chart;
        }
    }
}
