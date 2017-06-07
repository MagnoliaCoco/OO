using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFile file1, file2, file3, file4, file5, folder1, folder2, folder3, folder4;
            folder1 = new Folder("my file");
            folder2 = new Folder("image");
            folder3 = new Folder("text");
            folder4 = new Folder("vidoe");

            file1 = new ImageFile("a.jpg");
            file2 = new ImageFile("b.gif");
            file3 = new TextFile("c.txt");
            file4 = new TextFile("d.doc");
            file5 = new VidoeFile("e.mp4");

            folder2.Add(file1);
            folder2.Add(file2);
            folder3.Add(file3);
            folder3.Add(file4);
            folder4.Add(file5);
            folder1.Add(folder2);
            folder1.Add(folder3);
            folder1.Add(folder4);

            folder1.KillVirus();

            Console.ReadKey(true);
        }
    }
}