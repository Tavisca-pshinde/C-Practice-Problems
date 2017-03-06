using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchUsingLinkedList
{
    class Program
    {
        static int size;
        static void Main(string[] args)
        {
            int dataToInsert;
            BinarySearchTree insertion = new BinarySearchTree();
            Console.WriteLine("Enter size:");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer element :");
            for(int index=0;index<size;index++)
            {
                dataToInsert= Convert.ToInt32(Console.ReadLine());
                insertion.InsertData(dataToInsert);
            }
            Console.WriteLine("Inorder Traversal : ");
            Inorder inorder = new Inorder();
            inorder.InorderMethod(insertion.ReturnRoot());
            Console.WriteLine("\nPreorder Traversal : ");
            PreOrder preorder = new PreOrder();
            preorder.PreorderMethod(insertion.ReturnRoot());
            Console.WriteLine("\nPostOrder Traversal : ");
            PostOrder postorder = new PostOrder();
            postorder.PostorderMethod(insertion.ReturnRoot());

        }
    }
}
