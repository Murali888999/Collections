using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class D
    {
        static void Main(string[] args)
        {
            var j = new Stack<string>();
            j.Push("kalp");
            j.Push("murali");
            j.Push("balu");
            j.Push("giri");
            j.Push("giri");
            j.Push("venu");
            //j.Push("venu");
            foreach(string k in j)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("peek element:" + j.Peek());
            Console.WriteLine("pop element:" + j.Pop());
            Console.WriteLine("after pop and peek:" + j.Peek());
            foreach (string k in j)
            {
                Console.WriteLine(k);
            }
            Console.Read();
        }
    }
}
