using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            HashSet<string> hashSet = new HashSet<string>();

            // Add elements to the collections
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Durian");
            list.Add("Cherry");
            list.Add("Cherry"); // Adding duplicate element

            stack.Push("Apple");
            stack.Push("Banana");
            stack.Push("Durian");
            stack.Push("Cherry");
            stack.Push("Cherry"); // Adding duplicate element

            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Durian");
            queue.Enqueue("Cherry");
            queue.Enqueue("Cherry"); // Adding duplicate element

            hashSet.Add("Apple");
            hashSet.Add("Banana");
            hashSet.Add("Durian");
            hashSet.Add("Cherry");
            hashSet.Add("Cherry"); // Adding duplicate element
        }
    }
}
