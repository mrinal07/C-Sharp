using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//static is a modifier in C# which is applicable for the following: 
//Classes, Variables, Methods, Constructor, Properties, Event.
// We cannot create an object of static class and also we cannot inherit static class.

namespace StaticKeyword
{
    // Static classes are used as containers for all static members(types,methods,etc)
    // When we dont want someone to create an instance of our class then we made our class as static class

    static class StaticDemo
    {

        // 1) Variables and properties

        public static int id;
        public static string name { get; set; }

        // 2)Constructor:: Error: Static class cannot have instance constructor
        //public StaticDemo(){}

        // A static constructor must not contains any parameters.
        //static StaticDemo(int id, string name) { }

        //  Solution: replace access modifier with static
        static StaticDemo()
        {
            Console.WriteLine("Inside Static Constructor");
        }
        // 3) Methods

        public static void Display()
        {
             
            Console.WriteLine("Inside Demo Constructor");
            Console.WriteLine("Id: {0} and Name: {1}", id, name);
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Error: cannot create an instance of static class
            // StaticDemo sd = new StaticDemo();
            StaticDemo.id = 52;
            StaticDemo.name = "Mrinal";
            StaticDemo.Display();

        }
    }
}
