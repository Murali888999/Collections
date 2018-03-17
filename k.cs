using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class K
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(12);
            a.Add(23);
            a.Add(23);
            a.Add("murali");
            a.Add('c');
            foreach (object b in a)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine(a.Capacity);
            a.Insert(3, "kal");
            Console.WriteLine("\n after insert arraylist:");
            foreach (object b in a)
            {
                Console.WriteLine(b);
            }
           // a.Remove(3);
            a.RemoveAt(5); //removes based on index
            Console.WriteLine("\n after remove arraylist:");
            foreach (object b in a)
            {
                Console.WriteLine(b);
            }
            Console.Read();
        }
    }
}
