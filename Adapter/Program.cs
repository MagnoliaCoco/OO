using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace ConsoleApp3
{
    class Program
    {

        public static IConfigurationRoot Configuration { get; set; }

        static void Main(string[] args)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();


            string adapterType = Configuration["adapter"];

            //operation = (SO)Assembly.Load(new AssemblyName("ConsoleApp3")).CreateInstance(adapterType);

            SO operation = new OAdapter();
            int[] scores = { 84, 76, 50, 69, 90, 91, 88, 96 };
            int[] result;
            int score;

            Console.WriteLine("result:");
            result = operation.Sort(scores);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            score = operation.Search(result, 90);

            if(score != -1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("-1");
            }

            Console.ReadKey(true);
        }
    }
}