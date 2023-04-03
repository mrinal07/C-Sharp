using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

//Assignment 2

// Consider a base class MyClassA { }
// with few instance methods inside & a derived class of MyClassA is class MyClassB { }. 
// Class MyClassA { }
// has only 1 constructor which is parameterized & MyClassB has no user defined constructor. 
// Are we able to create an instance of the class MyClassB with following statement in main method 
// MyClassB mb1 = new MyClassB();
// if yes / no then why ? 

namespace Task2
{
    class MyClassA
    {
        public MyClassA(string name)
        {
            Console.WriteLine(name);
        }
        public void Display()
        {

        }

    }

    // Error on line 35
    class MyClassB: MyClassA
    {
        // Below parameterzied constructor must be implemented inorder to remove error
        //public MyClassB(string name): base(name) 
        //{

        //}

        public void Output()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Error on line 54
            MyClassB mb1 = new MyClassB("Mrinal");
            

            // If we are creating Derived(MyClassB) class object it will first go to Base(MyClassA) class constructor
            // through Derived class constructor.

            // Now in our scenario we have created a parameterzied constructor in Base class
            // Then it will mandatory for us to make a parameterzied constructor in Derived class
            // otherwise it will throw an error.

            // Then after removing the error we have to call like this.

        }
    }
}
