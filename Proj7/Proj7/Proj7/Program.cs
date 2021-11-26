using System;

namespace Proj7
{
    abstract class test1
    {
        public int add(int i, int j)
        {
            return i + j;
        }

        public abstract int mul(int i, int j);

    }

    class test2: test1
    {
        public override int mul(int i, int j)
        {
            return i * j;
        }
    }

    class test3: test1
    {
        public override int mul(int i, int j)
        {
            return i - j;
        }
    }

    class test4: test2
    {
        public override int mul(int i, int j)
        {
            return i + j;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test2 obj = new test4();
            int a = obj.mul(2, 4);
            test1 obj1 = new test2();
            int b = obj1.mul(4, 2);
            test1 obj2 = new test3();
            int c = obj2.mul(4, 2);
            Console.WriteLine("{0}, {1}, {2}",a,b,c);
        }
    }
}
