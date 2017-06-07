using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObserver
    {
        string Name
        {
            get;
            set;
        }
        void Help();
        void BeAttacked(AllyControlCenter acc);
    }
}
