using System;
using System.Collections;

namespace QueueAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // queue
            Queue qu = new Queue();
            qu.Enqueue("Hello");
            qu.Enqueue("World");
            qu.Enqueue("Welcome");
            qu.Enqueue("Team");


            Console.WriteLine("\nCount:{0}", qu.Count);
            Console.WriteLine("\n");

            // deqeue

            Queue dq = new Queue();
            dq.Enqueue("Mango");
            dq.Enqueue("Orange");
            dq.Enqueue("Graphes");
            dq.Enqueue("Apple");


            Console.WriteLine("Dequeue is \t{0}", dq.Dequeue());

            Console.WriteLine("Dequeue is \t{0}", dq.Dequeue());

            Console.WriteLine("Peek is \t{0}", dq.Peek());

            dq.Clear();

            Console.WriteLine("\n");

            // stack examples started //

            Stack my_stack = new Stack();

            my_stack.Push("Hello");
            my_stack.Push("Stack");
            my_stack.Push("Welcome");
            my_stack.Push(1234);
            my_stack.Push(490.98);

            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);
            }

            // 2nd example
            Console.WriteLine("\n");
            Stack new_stack = new Stack();

            new_stack.Push("Test");
            new_stack.Push("Test2");
            new_stack.Push("Test3");
            new_stack.Push("Test4");

            Console.WriteLine("Total elements present in" +
                  "new_stack: {0}", new_stack.Count);

            new_stack.Pop();

            Console.WriteLine("Topmost element of new_stack " +
                "is: {0}", new_stack.Peek());

            Console.WriteLine("Total elements present in " +
                 "new_stack: {0}", new_stack.Count);

            new_stack.Clear();

            Console.WriteLine("Total elements present in " +
                "new_stack: {0}", new_stack.Count);

        }
    }
}

