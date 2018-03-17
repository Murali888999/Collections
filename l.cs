using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class l
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add("name", "murali");
            h.Add("id", "1233");
            h.Add("age", "23");
            h.Add("email", "mohanggk@gmail.com");
            foreach (object kv in h.Keys)
            Console.WriteLine(kv+ ":"+h[kv]);
            Console.Read();
        }
    }
}
