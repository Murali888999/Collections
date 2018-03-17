using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class B1
    {
        static void Main(string[] args)
        {
            var V = new HashSet<int> { 12, 23, 34, 45,45,45,34 }; //duplicate values will not add..but it won't through any error
            foreach (int b in V)
            {
                Console.WriteLine(b);
            }
            Console.Read();
        }
    }
}
