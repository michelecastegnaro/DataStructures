using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CODA\n");

            CQueue Queue = new CQueue();
            Console.WriteLine(Queue.Enqueue(1));
            Console.WriteLine(Queue.Enqueue(2));
            Console.WriteLine(Queue.Enqueue(3));
            Console.WriteLine(Queue.Enqueue(4));
            Console.WriteLine(Queue.Dequeue());

            Console.WriteLine("\nPILA\n");

            CStack Stack = new CStack();
            Console.WriteLine(Stack.Pop(5));
            Console.WriteLine(Stack.Pop(6));
            Console.WriteLine(Stack.Pop(7));
            Console.WriteLine(Stack.Pop(8));
            Console.WriteLine(Convert.ToString(Stack.Push()));

            Console.WriteLine("\nALBERO\n");

            CBinaryTree Tree = new CBinaryTree();
            Console.WriteLine(Tree.Insert(5));
            Console.WriteLine(Tree.Insert(7));
            Console.WriteLine(Tree.Insert(3));
            Console.WriteLine(Tree.Insert(4));
            Console.WriteLine(Tree.Insert(2));
            Console.WriteLine(Tree.Insert(8));
            Console.WriteLine(Tree.Insert(6));

            //Tree.LevelOrder();
            //Tree.PreOrder();
            //Tree.PostOrder();
            //Tree.InOrder();
            //Tree.LevelOrder();
        }
    }
}
