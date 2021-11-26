using System;

namespace Proj2
{
    class xyz
    {
        public int result(int a,int b)
        {
            return a / b;
        }

        public float result(float a, float b)
        {
            return a - b;
        }

        public int result(int a, int b, int c)
        {
            return a * b * c;
        }

        public float result(float a,float b, float c)
        {
            return a + b + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int c, p, q, r;
            float x, y, z;
            xyz obj = new xyz();
            while (true)
            {
                /*Console.Clear();*/
                Console.WriteLine("Menu");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("Enter your choice (0 to exit): ");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Enter 3 floating point values:");
                        x = float.Parse(Console.ReadLine());
                        y = float.Parse(Console.ReadLine());
                        z = float.Parse(Console.ReadLine());
                        Console.WriteLine("Sum = " + obj.result(x, y, z));
                        break;
                    case 2:
                        Console.WriteLine("Enter 2 floating point values:");
                        x = float.Parse(Console.ReadLine());
                        y = float.Parse(Console.ReadLine());
                        Console.WriteLine("Difference = " + obj.result(x, y));
                        break;
                    case 3:
                        Console.WriteLine("Enter 3 natural numbers:");
                        p = int.Parse(Console.ReadLine());
                        q = int.Parse(Console.ReadLine());
                        r = int.Parse(Console.ReadLine());
                        Console.WriteLine("Product = " + obj.result(p,q,r));
                        break;
                    case 4:
                        Console.WriteLine("Enter 2 natural numbers:");
                        p = int.Parse(Console.ReadLine());
                        q = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quotient = " + obj.result(p,q));
                        break;
                    case 0:
                        System.Environment.Exit(1);
                        break;
                }
            }
            
        }
    }
}
