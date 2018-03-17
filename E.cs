using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class E
    {
        static void Main(string[] args)
        {
            var p = new Queue<string>();
            p.Enqueue("murali");
            p.Enqueue("venu");
            p.Enqueue("mohan");
            p.Enqueue("giri");
            foreach(string k in p)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("peeek element:" + p.Peek());
            Console.WriteLine("Dequeue a element:" + p.Dequeue());
            Console.WriteLine("after dequeue, peek element:" + p.Peek());
            Console.Read();
        }
    }
}
