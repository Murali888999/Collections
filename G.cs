using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class G
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("1","venu");
            d.Add("2", "giri");
            d.Add("3", "balu");
            d.Add("4", "balu");
            foreach (KeyValuePair<string,string> kv in d)
            {
                Console.WriteLine(kv);
            }
            d.Remove("4");
            Console.WriteLine("\n after remove key ,values are:");
            foreach (KeyValuePair<string, string> kv in d)
            {
                Console.WriteLine(kv);
            }
            Console.Read();
        }
    }
}
