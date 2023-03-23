using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fendahl.CustomLibrary;

namespace AccessModifiersWithAnotherProject
{
    internal class Program:ArithmeticOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Access Modifiers With Another Project");
            Console.WriteLine("AccessModifiers Examples");
            Console.WriteLine("public , private , protected , internal , protected internal , private protected");

            // 1) Accessing data members from other class and other project without inheritance.
            // cannot access private, protected, internal, protected internal members.
            ArithmeticOperations ao = new ArithmeticOperations();
            //Console.WriteLine(ao.a + " " + ao.b + " " + ao.c+ " " + ao.d + " " + ao.e);
            

            // 2) Accessing data members from other class and other project with inheritance.
            // cannot access private and internal members.
            Program p = new Program();
            //Console.WriteLine(p.a + " " + p.b + " " + p.c + " " + p.d + " " + p.e);



        }
    }
}
