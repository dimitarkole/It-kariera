using System;
using System.Collections.Generic;
using System.Text;

namespace CreateTree
{
   public class Tree<T>
    {
        private T value;
        private Tree<T>[] children;
        

        public T Value { get => value; set => this.value = value; }
        public Tree<T>[] Children { get => children; set => children = value; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.value = value;
            this.Children=children;
            
        }
        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.Value);
            foreach (var child in this.Children)
                child.Print(indent + 1);
        }
        public IEnumerable<T> OrderDFS()
        {
            List<T> order = new List<T>();
            this.DFS(this, order);
            return order;
        }

        private void DFS(Tree<T> tree, List<T> order)
        {
            foreach (var child in tree.Children)
                this.DFS(child, order);

            order.Add(tree.Value);
        }


    }
}
