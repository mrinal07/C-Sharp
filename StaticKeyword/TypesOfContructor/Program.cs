using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  In C#, constructors can be divided into 5 types
1) Default Constructor:A constructor without any parameters is called a default constructor;
in other words, this type of constructor does not take parameters.

2) Parameterized Constructor:A constructor with at least one parameter is called a 
parameterized constructor. The advantage of a parameterized constructor is that you 
can initialize each instance of the class with a different value.

3) Copy Constructor:The constructor which creates an object by copying variables from 
another object is called a copy constructor. The purpose of a copy constructor is to 
initialize a new instance to the values of an existing instance.

4) Static Constructor:
Static Constructor has to be invoked only once in the class and it has been invoked 
during the creation of the first reference to a static member in the class. 
A static constructor can not be a parametrized constructor.
Within a class, you can create one static constructor only. 
A static constructor is called automatically to initialize the class 
before the first instance is created or any static members are referenced.

5) Private Constructor: it is not possible for other classes to derive from this class, 
neither is it possible to create an instance of this class
 */

namespace TypesOfContructor
{
    internal class Program
    {
        int a, b;
        static int c;

        // 1) Default Constructor
        public Program()
        {
            a = 10;
            b = 20;

        }

        // 2) Parameterized  Constructor
        public Program(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        // 3) Copy Constructor

        public Program( Program p )
        {
            a = p.a;
            b = p.b;
        }

        // 4) Static Constructor

        static Program()
        {
            c = 100;
            // Static Constructor can be used in non static class
            Console.WriteLine("Static Constructor");
        }

        // 5) Private  Constructor
        // We can use Private  Constructor within class

        private Program(int x)
        {
            a = x;                
        }

        //static void Main(string[] args)
        //{
        //    // 1) Default Constructor
        //    Program p = new Program();
        //    Console.WriteLine(p.a+" "+p.b);

        //    // 2) Parameterized  Constructor
        //    p = new Program(52,53);
        //    Console.WriteLine(p.a+" "+p.b);

        //    // 3) Copy  Constructor
        //    Program p2 = new Program();
        //    p2.a = 999;
        //    p2.b = 777;

        //    p = new Program(p2);
        //    Console.WriteLine(p.a+" "+p.b);

        //    // 5) Private  Constructor
        //    // i)
        //    p = new Program(100);
        //    Console.WriteLine(p.a);

        //    // ii)
        //    // Error below
        //    //PrivateConstructorDemo pcd = new PrivateConstructorDemo();

        //    PrivateConstructorDemo pcd = new PrivateConstructorDemo(7);
            
        //}
    }

    class PrivateConstructorDemo
    {
        int a;
        //When a constructor is created with a private specifier, it is not possible
        //for other classes to derive from this class, neither is it possible to create
        //an instance of this class.

        private PrivateConstructorDemo()
        {
            Console.WriteLine("Inside Private Constructor ");
        }
        

        public PrivateConstructorDemo(int num)
        {
            a = num;
            Console.WriteLine("Inside Public Constructor "+a);
        }
    }
}
