using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static int choice;
        
        static void Main(string[] args)
        {
            String stringName;
            bool containsubString;
            String secondString;
            char checkEndOfString;
            char checkIndexOfString;
            Console.WriteLine("Enter a string :");
            stringName = Console.ReadLine();
            StringOperationDefinition check = new StringOperationDefinition();
            do
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.Contains()");
                Console.WriteLine("2.EndsWith(): Checks whether string ends with the given input");
                Console.WriteLine("3.IndexOf(): Returns the index of given input");
                Console.WriteLine("4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                           Console.WriteLine("Enter a string second string to check : ");
                           secondString = Console.ReadLine();
                        containsubString = check.ContainString(stringName,secondString);
                           Console.WriteLine(containsubString);                       
                           break;
                    case 2:
                          Console.WriteLine("Enter char you want to check:");
                          checkEndOfString= Convert.ToChar(Console.ReadLine());
                          check.EndsWith(stringName,checkEndOfString);
                          break;
                    case 3:
                          Console.WriteLine("Enter char to get index:");
                          checkIndexOfString = Convert.ToChar(Console.ReadLine());
                          check.IndexOfGivenString(stringName, checkIndexOfString);
                          break;                        
                    case 4:
                           Console.WriteLine("You are exiting");
                           break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            } while (choice != 4);
        }
    }
}
