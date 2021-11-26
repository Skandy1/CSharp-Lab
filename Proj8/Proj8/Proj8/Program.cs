using System;

namespace Proj8
{
    class Student
    {
        private string code = "N.A";
        private string name = "Not Knows";
        private int age = 0;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Code = "001";
            s.Name = "Skanda";
            s.Age = 23;
            Console.WriteLine("Student Info: {0}", s);
            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
        }
    }
}
