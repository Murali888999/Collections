using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class A
    {
        static void Main(string[] args)
        {
            var A = new List<string> { "murali","Atp","murali"};
            //var A = new List<string>();
            //A.Add("Murali");
            //A.Add("Atp");
            //A.Add("Ap");
            A.Insert(1, "mohan");
            A.RemoveAt(2);
            A.Remove("atp");
            Console.WriteLine("\n aftr insertion and deletion elements are:");
            foreach (string d in A )
            {
                Console.WriteLine(d);
            }
            Console.Read();
        }       
    }
}