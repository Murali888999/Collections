using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class I
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(3, "venu");
            sl.Add(4, "murali");
            sl.Add(1, "mohan");
            sl.Add(2, "giri");
            foreach(KeyValuePair<int,string> f in sl)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine(sl.IndexOfKey(3));
            sl.Remove(1);           
            Console.WriteLine("\n after remove elements are:");
            foreach (KeyValuePair<int, string> f in sl)
            {
                Console.WriteLine(f);
            }
            Console.Read();
        }
    }
}
