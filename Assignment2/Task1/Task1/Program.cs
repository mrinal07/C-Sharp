using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

//Assignment 1

//Consider Class Demo1 with instance methods D1() and D2().
//The class Demo1 has only 1 user-defined constructor and it is marked as private. 
//Considering the above situation, we can not instantiate the class Demo1 in any other class
//and also can not be able to access its method. 
//You are allowed to modify the class but do not add a constructor, do not inherit the
//class Demo1 & also do not modify the existing constructor.

//Try to find the solution to access the instance methods D1 and D2.

namespace Task1
{
    class Demo1
    {
        private Demo1()
        {
            Console.WriteLine("Demo1 constructor");
        }

        // Error below 

        //public void D1()
        //{
        //    Console.WriteLine("Demo1 D1");

        //}
        //public void D2()
        //{
        //    Console.WriteLine("Demo1 D2");

        //}

        public static void D2()
        {
            Console.WriteLine("Demo1 D2");

        }

        public static void D1()
        {
            Console.WriteLine("Demo1 D1");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Answer:
            // Static methods are connected to class which means we can call static method by classname only
            // where as non-static methods are connected to class objects that's why we can not call them without
            // creating an object.

            // This will throw an error

            //Demo1 demo1 = new Demo1();


            // Answer: we have to make methods as static so that we can access them without instantiate.

            Demo1.D1();
            Demo1.D2();


        }
    }
    
}
