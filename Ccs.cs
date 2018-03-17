using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Ccs
    {
        static void Main(string[] args)
        {
            var K = new SortedSet<String>() { { "murali" },{ "bhaskar"},{ "anil"},{ "madhu"},{ "bhargav"} };
            //K.Add("murali");
            //K.Add("bhaskar");
            //K.Add("anil");
            //K.Add("Madhu");
            //K.Add("bhargav");
            foreach(string g in K)
            {
                Console.WriteLine(g);
            }
            Console.Read();
        }
    }
}
