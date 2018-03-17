using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class M
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("murali");
            q.Enqueue("k");
            q.Enqueue(23);
            foreach(object obj in q)
            {
                Console.WriteLine(obj);
            }
            q.Dequeue();
            Console.WriteLine("\n afet remove elements are:");
            foreach (object obj in q)
            {
                Console.WriteLine(obj);
            }
            Console.Read();
        }
    }
}
