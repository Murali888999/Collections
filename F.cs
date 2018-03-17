using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class F
    {
        static void Main(string[] args)
        {
            var p = new LinkedList<string>();
            p.AddLast("venu");
            p.AddLast("murali");
            p.AddLast("giri");
            p.AddFirst("balu");
            foreach(string k in p)
            {
                Console.WriteLine(k);
            }
            LinkedListNode<string> node = p.Find("balu");
            p.AddBefore(node, "tippe");
            p.AddAfter(node, "manju");
           Console.WriteLine( p.Contains("venu"));
            Console.WriteLine("\n read elements after adding:");
            foreach (string k in p)
            {
                Console.WriteLine(k);
            }
            Console.Read();
        }
    }
}