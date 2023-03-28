using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfContructor
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Class Default Constructor");
        }

        public ParentClass(string name)
        {
            Console.WriteLine("Parent Class Parameterized Constructor "+name);
        }
    }

    class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child Class Default Constructor");

        }
        public ChildClass(string name): base(name) 
        {
            Console.WriteLine("Child Class Parameterized Constructor " + name);
        }
    }
    internal class ConstructorInheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Inheritance\n");
            ChildClass childClass = new ChildClass();
            ChildClass childClass2 = new ChildClass("Fendahl");

        }
    }
}
