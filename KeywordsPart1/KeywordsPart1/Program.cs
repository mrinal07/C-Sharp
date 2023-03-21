using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsPart1
{
    internal class Program
    {
        // enum keyword example:
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        // enum keyword example:
        class EnumDemo
        {
            public int id { get; set; }
            public Season s { get; set; }

            public override string ToString()
            {
                return "Id: " + id + " Season " + s;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Useful keywords Part 1 in C#\n");

            // 1) enum keyword example:
            EnumDemo ed = new EnumDemo();
            ed.id = 1;
            ed.s = Season.Spring;
            Console.WriteLine(ed);

            ed.id = 50;
            ed.s = Season.Autumn;
            int indexOfEnum = (int)ed.s;
            Console.WriteLine(ed + " " + indexOfEnum);

            //------------------------------------

            // 2) typeof keyword example

            //Console.WriteLine(typeof(int));
            //Console.WriteLine(typeof(long));
            //Console.WriteLine(typeof(object));
            //Console.WriteLine(typeof(double));

            //------------------------------------

            // 3) GetType keyword example

            //byte b = 10;
            //int i = 100;
            //long j = 10000;
            //double k = 456.2;
            //Console.WriteLine( b.GetType() );
            //Console.WriteLine( i.GetType() );
            //Console.WriteLine( j.GetType() );
            //Console.WriteLine( k.GetType() );

            // 4) this keyword example
            //The main reason why we can not use "this" in static method context:-
            //this :-"this" means current class OBJECT , so its clear that "this"
            //only come in the picture once we intended to create an Object of that class.

            //static method:- there is no need to create an object in order to use static
            //method.means "instance" or object creation doesn't any sense with "static" as per Java rule.

            //So There would be contradiction,if we use both together(static and this) . That is the reason we can not use "this" in static method.

            Employee e = new Employee("Keyboard-Type", "QWERTY");
            Console.WriteLine(e);

            Console.ReadKey();
        }

        // this keyword example
        class Employee
        {
            private string alias;
            private string name;

            public Employee(string name, string alias)
            {
                // Use this to qualify the members of the class
                // instead of the constructor parameters.
                this.name = name;
                this.alias = alias;
            }
            public override string ToString()
            {
                return "Name: " + name + " Alias: " + alias;
            }
        }
    }
}
