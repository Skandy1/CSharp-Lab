using System;

namespace Proj1
{
    class Program
    {
        static int GCD(int a,int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(args[1]);
            int x, y;
            Console.WriteLine("GCD Calculator");
            Console.WriteLine("Value 1:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Value 2:");
            y= int.Parse(Console.ReadLine());
            Console.WriteLine("GCD of {0} and {1} is {2}", x,y,GCD(x,y));
        }
    }
}
