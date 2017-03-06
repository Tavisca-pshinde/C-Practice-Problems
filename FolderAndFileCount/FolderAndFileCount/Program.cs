using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderAndFileCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Folder Path : ");
            String path = Console.ReadLine();
            DirectoryCheck directoryCheck = new DirectoryCheck();
            directoryCheck.DisplayFoldersAndFiles(path);
            Console.ReadKey();
        }
    }
}
