using System;
using System.Collections.Generic;

namespace BTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(5);
            tree.Add(51);
            tree.Add(1);
            tree.Add(4);
            tree.Add(15);
            tree.Remove(15);

            Console.WriteLine(tree.ToString());
            Console.WriteLine(tree.Contains(4));
        }
    }
}
