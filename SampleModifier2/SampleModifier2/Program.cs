using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModifier2
{
    public class A
    {
        private int P=100;
        public int Q=200;
        protected int R=300;
        internal int S=400;
        protected internal int T=500;


        public void getId( int i )
        {
            P = i;
            Console.WriteLine(P);
        }


    }


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample 2");
        }
    }
}
