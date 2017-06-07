using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Player : IObserver
    {
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Help(){
            Console.WriteLine("{0} gets", this.name);
        }
        public void BeAttacked(AllyControlCenter acc)
        {
            Console.WriteLine("{0} emits", this.name);
            acc.NotifyObserver(name);
        }
    }
}
