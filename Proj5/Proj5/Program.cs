using System;

namespace Proj5
{
    class super
    {
        protected int x;
        public super(int x)
        {
            this.x = x;
        }

        public virtual void display()
        {
            Console.WriteLine("\n Super x = " + x);
        }
    }
    class Program:super
    {
        int y;
        public Program(int x,int y) : base(x)
        {
            this.y = y;
        }

        public override void display()
        {
            Console.WriteLine("\n Sub x = " + x);
            Console.WriteLine("\n Sub y = " + y);
        }
        static void Main(string[] args)
        {
            Program s = new Program(100, 200);
            s.display();
            
        }
    }
}
