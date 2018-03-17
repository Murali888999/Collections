using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class J
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(12);
            a.Add(2.3);
            a.Add(true);
            a.Add("murali");
            a.Add('c');
            foreach(object b in a)
            {
                Console.WriteLine(b);
            }
            Console.Read();
       }
    }
}
