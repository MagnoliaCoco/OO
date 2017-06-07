using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AllyControlCenter acc;
            acc = new ConcreteAllyControlCenter("0");

            IObserver player1, player2, player3, player4;
            player1 = new Player("a");
            acc.Join(player1);
            player2 = new Player("b");
            acc.Join(player2);
            player3 = new Player("c");
            acc.Join(player3);
            player4 = new Player("d");
            acc.Join(player4);

            player1.BeAttacked(acc);

            Console.ReadKey(true);
        }
    }
}