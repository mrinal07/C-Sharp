using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assignment 3

//Consider following method overload : 
//void Add(string s1, object a1)
//void Add(object a1, string s1)

//Method call
//Add(null, null); // Which method gets called ? 
//if you can call any of the overloaded versions of the method or get an error. Justify the compiler behavior.


namespace Task3
{
    class DemoMethodOverload
    {
        public void Add(string s1, object a1)
        {
            Console.WriteLine("Insied Add(string s1, object a1) ");
            Console.WriteLine( s1 +" || "+a1 );

        }
        public void Add( object a1, string s1)
        {
            Console.WriteLine("Insied Add( object a1, string s1) ");
            Console.WriteLine( a1 +" || "+s1 );

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoMethodOverload obj = new DemoMethodOverload();

            // If we call these functions by passing null arguments then the compiler show 
            // ambiguity  error as we can see in java and c# when we implementing multiple inheritance.
            obj.Add(null, null);
            obj.Add(null, null);

            // But if we do not pass null arguments instead of passing actuall values then compiler don't
            // have any error.            
            obj.Add("QWERTY", obj);
            obj.Add(obj, "AZERTY");

            // Reason for this is: both string and object data types are known as refernce type
            // which means we can pass null values to them, Therefore compiler is showing ambiguity  error.

            // As we know, a value type ie int,float cannot be assigned a null value.


        }
    }
}
