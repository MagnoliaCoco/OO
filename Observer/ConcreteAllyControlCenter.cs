using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteAllyControlCenter : AllyControlCenter
    {
        public ConcreteAllyControlCenter(string allyName)
        {
            Console.WriteLine("{0} create success", allyName);
            Console.WriteLine("---------------------------");
            this.allyName = allyName;
        }

        public override void NotifyObserver(string name)
        {
            Console.WriteLine("{0} notify : {1}");

            foreach (object obj in players)
            {
                if (!((IObserver)obj).Name.Equals(name))
                {
                    ((IObserver)obj).Help();
                }
            }
        }
    }
}
