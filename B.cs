using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class B
    {
        static void Main(string[] args)
        {
            var V = new HashSet<int> { 12, 23, 34, 45 };
            //var V = new HashSet<int>();
            //V.Add(12);
            //V.Add(23);
            //V.Add(34);
            //V.Add(45);
            foreach(int b in V)
            {
                Console.WriteLine(b);
            }
            Console.Read();
        }
    }
}
