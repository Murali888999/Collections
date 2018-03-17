using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class N
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("venu");
            s.Push(25);
            s.Push("venu@gmail.com");
            s.Push(1234);
            foreach(object ka in s)
            {
                Console.WriteLine(ka);
            }
            Console.WriteLine("peek:" +s.Peek());
            Console.WriteLine("pop:" + s.Pop());
            Console.WriteLine("\n after peek and pop elements are:");
            foreach (object ka in s)
            {
                Console.WriteLine(ka);
            }
            Console.Read();
        }
    }
}
