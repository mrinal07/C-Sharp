using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleModifier2;

namespace SampleModifier
{
    internal class Program:A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample 1");

            A obj = new A();
            obj.getId(52);
            Console.WriteLine( obj.Q );
            // cannot access below data types
            //Console.WriteLine( obj.P );
            //Console.WriteLine( obj.R );
            //Console.WriteLine( obj.S );
            //Console.WriteLine( obj.T );

            Program p = new Program();
            Console.WriteLine( p.Q );
            Console.WriteLine( p.R );
            Console.WriteLine( p.T );
            // Cannot access below data types.
            //Console.WriteLine( p.S );
            //Console.WriteLine( p.P );


            B obj2 = new B();
            obj2.getId(25);

            Console.WriteLine( );
        }
    }
}
