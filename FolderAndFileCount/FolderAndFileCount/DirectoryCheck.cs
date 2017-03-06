using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderAndFileCount
{
    class DirectoryCheck
    {
         
       public void DisplayFoldersAndFiles(string path)
        {
            int directoryCount = Directory.GetDirectories(@path, "*.*", 
            SearchOption.AllDirectories).Length;
            Console.WriteLine("Total Number of Folder : " + directoryCount);

            int fileCount = Directory.GetFiles(@path, "*.*", SearchOption.AllDirectories).Length;
            Console.WriteLine("Total Number of Files : " + fileCount);
        }
    }
}
   
