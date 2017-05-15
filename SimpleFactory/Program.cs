using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Chart chart = CFactory.GetChart("H");
            chart.Display();
            Console.ReadKey(true);
        }
    }
}