using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Folder : AbstractFile
    {
        private List<AbstractFile> fileList = new List<AbstractFile>();
        private string name;

        public Folder(string name)
        {
            this.name = name;
        }

        public override void Add(AbstractFile file)
        {
            fileList.Add(file);
        }

        public override void Remove(AbstractFile file)
        {
            fileList.Remove(file);
        }

        public override AbstractFile GetChild(int i)
        {
            return (AbstractFile)fileList[i];
        }

        public override void KillVirus()
        {
            Console.WriteLine("**  folder {0}", this.name);

            foreach (Object obj in fileList)
            {
                ((AbstractFile)obj).KillVirus();
            }
        }
    }
}
