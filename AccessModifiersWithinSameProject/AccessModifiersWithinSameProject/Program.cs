using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersWithinSameProject
{
    internal class Program: GettingAccessModifiers
    {
        private int a = 10;
        public int b = 20;
        protected int c = 30;
        internal int d = 40;
        protected internal int e = 50;

        static void Main(string[] args)
        {
            Console.WriteLine("AccessModifiers Examples");
            Console.WriteLine("public , private , protected , internal , protected internal , private protected");

            // 1) Accessing data members within same class.
            Program p = new Program();
            Console.WriteLine(p.a + " " + p.b + " " + p.c + " " + p.d + " " + p.e);


            // 2) Accessing data members from other class within the same project without inheritance.
            // cannot access private and protected members.
            GettingAccessModifiers g = new GettingAccessModifiers();
            //Console.WriteLine(g.p + " " + g.q + " " + g.r + " " + g.s + " " + g.t);


            // 3) Accessing data members from other class within the same project with inheritance.            
            // cannot access private members.
            Program p2 = new Program();
            //Console.WriteLine(p2.p + " " + p2.q + " " + p2.r + " " + p2.s + " " + p2.t);
            Console.Read();
        }
    }
}
