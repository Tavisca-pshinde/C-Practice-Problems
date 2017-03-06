using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class StringOperationDefinition
    {

        public bool ContainString(String firstString,String secondString)
        {
            int index = 0, iterator=0,flag=0; 
            int lengthOriginalString,lengtOfCheckString;
            lengthOriginalString = firstString.Length;
            lengtOfCheckString = secondString.Length;
            char[] originalString = firstString.ToCharArray();
            char[] checkString = secondString.ToCharArray();
            
            while(index<lengthOriginalString)
            {
                if (iterator < lengtOfCheckString)
                {
                    if (originalString[index] == checkString[iterator])
                    {
                        if (iterator == 0)
                        {
                            flag = 1;
                        }
                        index++;
                        iterator++;

                    }
                    else
                    {
                        index++;
                        if (flag == 1)
                        {
                            return false;
                        }
                    }
                }
                
               


            }
            if(iterator== (lengtOfCheckString))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void EndsWith(String stringName, char check)
        {
            
            int length;
            char[] checkString = stringName.ToCharArray();

            length = checkString.Length;
            if(checkString[length-1]==check)
            {
                Console.WriteLine("string ends with entered char");
            }
            else
            {
                Console.WriteLine("string does not end with entered string");
            }       
        }

        public void IndexOfGivenString(String stringName, char check)
        {
            int length;
            int index = 0;
            char[] checkString = stringName.ToCharArray();

            length = checkString.Length;
            while(index<length)
            {
                if(checkString[index]==check)
                {
                    Console.WriteLine("string contains given char at {0}",index);
                    return;
                }
                index++;
            }
            Console.WriteLine("string does not contain given char");

        }
    }
}
