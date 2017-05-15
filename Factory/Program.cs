using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            LFactory factory;
            Logger logger;
            factory = new FLF();
            logger = factory.CreateLogger();
            logger.WriteLog();

            Console.ReadKey(true);
        }
    }
}