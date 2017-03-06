using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchUsingLinkedList
{
    class Inorder
    {
        public void InorderMethod(Node Root)
        {
            if (Root != null)
            {
                InorderMethod(Root.leftPointer);
                Console.Write(Root.data + " ");
                InorderMethod(Root.rightPointer);
            }
        }
    }
}
