using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    abstract class AllyControlCenter
    {
        protected string allyName;
        protected List<IObserver> players = new List<IObserver>();

        public void GetAllyName(string allyName)
        {
            this.allyName = allyName;
        }

        public string GetAllyName()
        {
            return this.allyName;
        }

        public void Join(IObserver obs)
        {
            Console.WriteLine("{0} join {1}", obs.Name, this.allyName);
            players.Add(obs);
        }

        public void Quit(IObserver obs)
        {
            Console.WriteLine("{0} quit {1}", obs.Name, this.allyName);
            players.Add(obs);
        }

        public abstract void NotifyObserver(string name);
    }
}
