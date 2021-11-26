using System;

namespace Proj3
{
    class constrctOverload
    {
        string user;
        int age;
        public constrctOverload()
        {
            user = "Stever Jobs";
            age = 28;
            Console.WriteLine("Previous User {0} and he was {1} year old", user, age);
        }

        public constrctOverload(string name, int age1)
        {
            this.user = name;
            this.age = age1;
            Console.WriteLine("Current User {0} and he is {1} years old", user, age);
        }

    }
    class Program
    {
        public int a, b;
        public Program(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static Program operator +(Program c1, Program c2)
        {
            return new Program(c1.a + c2.a, c1.b + c2.b);
        }

        public override string ToString()
        {
            return (String.Format("A == {0} B == {1}", a, b));
        }
        static void Main(string[] args)
        {
            constrctOverload a1, a2;
            a1 = new constrctOverload();
            a2 = new constrctOverload("Bill Gates", 43);
            Program p1, p2;
            p1 = new Program(9, 3);
            p2 = new Program(3, 4);
            Program p3 = p1 + p2;
            Console.WriteLine("Result {0}", p3);
            Console.ReadLine();
        }
    }
}
