using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    //Method Overloading
    class OverloadingDemo
    {
        public int ParentId { get; set; }
        public string ParentName { get; set; }

        // Method overloading with same name, return type but different parameters
        public void show(int pId)
        {
            Console.WriteLine(pId);
        }
        public void show(string pName)
        {
            Console.WriteLine(pName);
        }

        // Method overloading with same name but different return type and parameters.
        public int display(int pId)
        {
            return pId;
        }

        // this will give error =>
        //Type 'OverloadingDemo' already defines a member called 'display' with the same parameter types
        //public string display(int pId)
        //{
        //    return pId+"";
        //}


        public string display(string pName)
        {
            return pName;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Method Overloading");

            OverloadingDemo obj = new OverloadingDemo();

            // Method overloading with same name, return type but different parameters
            obj.show(10);
            obj.show("Mrinal");

            Console.WriteLine();
            // Method overloading with same name but different return type and parameters.
            Console.WriteLine(obj.display(20));
            Console.WriteLine(obj.display("Shubham"));
            Console.Read();

        }
    }
}
