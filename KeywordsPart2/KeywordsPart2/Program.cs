using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsPart2
{
    internal class Program
    {
        // ref keyword example
        public void checkRefType(ref int a, int b)
        {
            a = a + 100;
            b = 200;
        }

        // out keyword example
        public void checkOutType(out int a, int b)
        {
            // if we dont write this line it will throw an error
            a = 0;
            a = a + 100;
            b = 200;

        }

        // 3) readonly keyword example
        readonly string name = "Mrinal";
        readonly double pi;

        // error => 
        //Feature 'readonly methods' is not available in C# 7.3. Please use language version 8.0 or greater.
        //public readonly void msg()
        //{
        //    Console.WriteLine("Inside readonly method msg()");
        //}

        //4) const keyword example
        const double PI = 3.142;


        static void Main(string[] args)
        {
            Console.WriteLine("Useful keywords Part 2 in C#\n");

            // 1) ref keyword example
            int a = 10, b = 20;
            Console.WriteLine(a + " " + b);

            Program p = new Program();
            p.checkRefType(ref a, b);
            Console.WriteLine(a + " " + b);

            //------------------------------

            // 2) out keyword example
            //Console.WriteLine();

            //a = 10;
            //b = 20;
            //Console.WriteLine(a + " " + b);

            //p = new Program();
            //p.checkOutType(out a, b);
            //Console.WriteLine(a + " " + b);
            //------------------------------

            // 3) readonly keyword example

            // it will throw an error
            //p.name = "Kunal"; 

            p = new Program(3.142);
            Console.WriteLine("readonly pi: " + p.pi);

            


            //4) const keyword example
            Console.WriteLine("const pi: " + Program.PI);

            Console.ReadKey();

        }

        public Program() { }

        public Program(double xx)
        {
            pi = xx;
        }
    }


}
