using System;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            SO operation = new OAdapter();

            int[] scores = { 84, 76, 50, 69, 90, 91, 88, 96 };
            int[] result;
            int score;

            Console.WriteLine("result");
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