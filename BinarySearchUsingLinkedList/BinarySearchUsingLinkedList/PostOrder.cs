using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchUsingLinkedList
{
    class PostOrder
    {
        public void PostorderMethod(Node Root)
        {
            if (Root != null)
            {
                PostorderMethod(Root.leftPointer);
                PostorderMethod(Root.rightPointer);
                Console.Write(Root.data + " ");
            }
        }
    }
}
