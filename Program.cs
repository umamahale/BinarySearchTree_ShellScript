using System;

namespace BTree
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1BinaryTree tree = new UC1BinaryTree();
            Node root = new Node();

            tree.Insert(56);
            tree.Insert(30);
            tree.Insert(70);
            tree.DisplayTree();

        }
            

      

    }
}
    

