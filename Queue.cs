using System;
using System.Collections.Generic;
namespace myApp
{
    public class Queue
    {

        public static void Main45() {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Contains(2));
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.Peek();
            queue.Clear();
            Dictionary<int, string> dict = new Dictionary<int, string>();
        }
        
    }
}