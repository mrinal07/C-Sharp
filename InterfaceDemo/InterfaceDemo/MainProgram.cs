using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1) An interface defines a signature of methods, events and indexes but not an implementation.

// 2) The interface members don't have any access specifier, by default they are public.

// 3) By default an interface is internal and we can't declare it private, protected or
// protected internal because it is always inherited by classes but we can use public.

// 4) An interface does not have fields; in other words we can't declare variables in an interface.
// default interface feature is there in C# 8.0 or higher

// 5) Should use a public access specifier for inherited members from an interface to a class.
// By default all members are public in interfaces but when we implement a method in a class
// we need to define it as public.

// 


namespace InterfaceDemo
{
    internal class MainProgram:Demo
    {
        static void Main(string[] args)
        {
            // Implicit
            Shape shape = new Shape();
            shape.DrawShape();
            shape.ColorTheShape();
            Console.WriteLine();

            // Another way of calling

            IShape obj = new Shape();
            obj.DrawShape();
            obj.ColorTheShape();
            Console.WriteLine();



            // Explicit

            // Error below
            //Shape2 shape2 = new Shape2();
            //shape2.DrawShape();
            //shape2.ColorTheShape();


            // An explicitly implemented member cannot be accessed using a class instance,
            // but only through an instance of the interface.

            // The main reason for explicit interface definitions is to avoid naming
            // conflicts if you happen to implement two interfaces that contain methods with the same signature...
            // the explicit definition allows the compiler to keep the signatures distinct enough to resolve.
            // It is more readable and eliminates the confusion.
            // It is also useful if interfaces have the same method name coincidently.


            IShape obj2 = new Shape2();
            obj2.DrawShape();
            obj2.ColorTheShape();
            Console.WriteLine();

            //IShape shape1; // Use???


            MainProgram p = new MainProgram();
            p.DrawShape();
            

        }

        public override void Output()
        {
            throw new NotImplementedException();
        }
    }
}
