using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string instruction = "down run 10 and left move 20";
            InstructionHandler handler = new InstructionHandler();
            handler.Handle(instruction);

            string outString;
            outString = handler.Output();
            Console.WriteLine(outString);

            Console.ReadKey(true);
        }
    }
}