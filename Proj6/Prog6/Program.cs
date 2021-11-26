using System;

namespace Prog6
{
    public delegate int DelegateSample(int a, int b);
    public class sampleClass
    {
        public int add(int x,int y)
        {
            return x + y;
        }
        public int sub(int x,int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sampleClass s = new sampleClass();
            DelegateSample del = s.add;
            int i = del(10, 20);
            Console.WriteLine("Add result is " + i);
            DelegateSample del1 = s.sub;
            int j = del1(10, 2);
            Console.WriteLine("Sub result is " + j);
        }
    }
}
