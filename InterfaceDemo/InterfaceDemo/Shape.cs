using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1 Why we cannot create obj of abstract class and interface

// 2 why by deafult public in interface, if public then any one can access this

// 3 After writing public before method in interface still we get error
// Ans: Interface is a contract and anywhere where you can access the interface,
// you should be able to access all the methods in it. In other words, all the
// methods declared in the interface are supposed to be public so it doesn't make
// sense stating it explicitly.

// 4 can we create constructor in abstract class, if yes then tell its type

namespace InterfaceDemo
{
    // Only interface
    interface IShape
    {
        //string Name { get; set; }
         void DrawShape();
        void ColorTheShape();
    }
    class Shape : IShape
    {
        //string IShape.Name { get ; set; }

        // Error below: because Name is private in IShape
        string Name { get ; set; }

        public void ColorTheShape()
        {
            Console.WriteLine("Inside Shape Class");
            Console.WriteLine("Coloring the rectangle.");
            
        }

        public void DrawShape()
        {
            Console.WriteLine("Inside Shape Class");
            Console.WriteLine("Drawing rectangle");
        }
    }

    class Shape2 : IShape
    {
        void IShape.ColorTheShape()
        {
            Console.WriteLine("Inside Shape2 Class");
            Console.WriteLine("Coloring the rectangle.");
        }

        void IShape.DrawShape()
        {
            Console.WriteLine("Inside Shape2 Class");
            Console.WriteLine("Drawing rectangle");
        }
    }

    // Multiple Inheritance using Interface

    class Shape3 : Shape, IShape
    {
        public new void ColorTheShape()
        {
            Console.WriteLine("Inside Shape3 Class");
            Console.WriteLine("Coloring the rectangle.");

        }

        public new void DrawShape()
        {
            Console.WriteLine("Inside Shape3 Class");
            Console.WriteLine("Drawing rectangle");
        }
        public void Display()
        {
            Console.WriteLine("Inside Shape3 Class Display method");
        }
    }


    // Implementing Interface in abstract class
    abstract class Demo : IShape
    {
        int id;
        public Demo()
        {
            id = 101;
            Console.WriteLine("Abstract Class constructor "+id);
        }
        public void ColorTheShape()
        {
            Console.WriteLine("Inside abstract class Demo");
            Console.WriteLine("Coloring the rectangle.");
        }

        public void DrawShape()
        {
            Console.WriteLine("Inside abstract class Demo");
            Console.WriteLine("Drawing rectangle");
        }

        public void Display()
        {
            Console.WriteLine("Inside Shape3 Class Display method");
        }

        abstract public void Output();
        
    }




}
