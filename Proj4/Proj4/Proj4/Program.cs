using System;

namespace Proj4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                Console.WriteLine("In try block: attempting to divide by zero");
                int myInt = 1 / zero;
                Console.WriteLine("No Message");
            }catch(ArithmeticException e)
            {
                Console.WriteLine("In catch Block: an exception was thrown");
                Console.WriteLine("\n" + e);
            }

            try
            {
                string x = "abcde";
                char a1 = x[1];
                char a2 = x[100];
                Console.WriteLine(a1);
                Console.WriteLine(a2);
            } catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range:");
                Console.WriteLine("  " + e);
            }
            finally
            {
                Console.WriteLine("Finally block!");
            }

        }
    }
}
