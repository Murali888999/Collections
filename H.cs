using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class H
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> s = new SortedDictionary<int, string>();
            s.Add(5, "balu");
            s.Add(2, "murali");
            s.Add(1, "giri");
            s.Add(4, "venu");
            foreach(KeyValuePair<int, string> sd in s)
            {
                Console.WriteLine(sd);
            }           
            s.Remove(5);
            Console.WriteLine("\n after remove elements are:");
            foreach (KeyValuePair<int, string> sd in s)
            {
                Console.WriteLine(sd);
            }
            Console.Read();
        }
    }
}
 