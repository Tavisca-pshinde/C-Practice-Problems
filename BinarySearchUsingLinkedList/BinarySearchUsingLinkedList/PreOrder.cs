using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchUsingLinkedList
{
    class PreOrder
    {
        public void PreorderMethod(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.data + " ");
                PreorderMethod(Root.leftPointer);
                PreorderMethod(Root.rightPointer);
            }
        }
    }
}
