using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class VidoeFile : AbstractFile
    {
        private string name;

        public VidoeFile(string name)
        {
            this.name = name;
        }

        public override void Add(AbstractFile file)
        {
            Console.WriteLine("no mathod supported");
        }

        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("no mathod supported");
        }

        public override AbstractFile GetChild(int i)
        {
            Console.WriteLine("no mathod supported");
            return null;
        }

        public override void KillVirus()
        {
            Console.WriteLine("---- vidoe {0}", this.name);
        }
    }
}
