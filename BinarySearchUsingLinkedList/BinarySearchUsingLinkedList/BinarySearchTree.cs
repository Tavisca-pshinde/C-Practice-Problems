using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchUsingLinkedList
{
    class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void InsertData(int data)
        {
            Node newNodeToInsert = new Node();
            newNodeToInsert.data = data;
            if (root == null)
            {
                root = newNodeToInsert;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.leftPointer;
                        if (current == null)
                        {
                            parent.leftPointer = newNodeToInsert;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightPointer;
                        if (current == null)
                        {
                            parent.rightPointer = newNodeToInsert;
                            return;
                        }
                    }
                }
            }
        }



    }
}
