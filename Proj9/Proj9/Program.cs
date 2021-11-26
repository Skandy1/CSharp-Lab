using System;
using System.Collections.Generic;

namespace Proj9
{
    class Program
    {
        public static void FindMatches(IList<String> list, Object[] ob)
        {
            Console.WriteLine("Match array is:");
            foreach(Object o in ob)
            {
                Console.WriteLine(" {0} ", o.ToString());
            }

            foreach(Object o in ob)
            {
                if (list.Contains(o.ToString()))
                {
                    Console.WriteLine("\n List Contains {0} at index {1}", o, list.IndexOf(o.ToString()));
                }
            }
        }
        static void Main(string[] args)
        {
            string[] strings = { "one", "two", "four", "eight" };
            Console.WriteLine("Strings array values: \n");
            foreach(String s in strings)
            {
                Console.WriteLine(" {0} ", s);
            }

            Console.WriteLine("\n");
            FindMatches(strings, new String[] { "zero", "one", "five", "eight" });
        }
    }
}
