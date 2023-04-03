using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assignment 4

//-- > Consider following method implementations : 
//	void Add(int a, int b)

//    void Add(double a, double b)

//    void Add(int a, double b)


//--> Understand practically, which method will hit by the following calls
//	1. Add(10, 20)
//	2. Add(20, 20.30)
//  3. Add(30.3, 10.0)

namespace Task4
{
    internal class Program
    {
        void Add(int a, int b)
        {
            Console.WriteLine(a+" "+b);

        }

        void Add(double a, double b)
        {
            Console.WriteLine(a+" "+b);

        }

        void Add(int a, double b)
        {
            Console.WriteLine(a+" "+b);

        }

        static void Main(string[] args)
        {
            // This concept is one of the pillar of OOP's
            // ie: Polymorphism 
            // Now in Polymorphism we have two sub types i) Method Overloading, ii) Method Overriding.

            // Here we implemented Method Overloading which means we can use methods having same name with
            // different parameters.

            // It makes the program more readable, programmer can use same method names with different data types.
            // Also Overloading is determined at compile time, not runtime.

            // Also it reduces the execution time, because everything is done at compile time rather than runtime.

            Program p = new Program();
            p.Add(10, 20);
            p.Add(20, 20.30);
            p.Add(30.3, 10.0);
        }
    }
}
