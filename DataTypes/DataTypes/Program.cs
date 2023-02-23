using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        //Implicit Casting(automatically) - converting a smaller type to a larger type size
        //char -> int -> long -> float -> double

        //Explicit Casting(manually) - converting a larger type to a smaller size type
        //double -> float -> long -> int -> char
        static void Main(string[] args)
        {
            // because the range of char (-2^15 to 2^15 - 1) is much smaller than the
            // range of int (-2^31 to 2^31 - 1). The compiler sees you are trying to
            // assign an int to a char, and stops you, because it realizes this.
            //char c = 97;
            //char c = 150;
            int i = 'a';

            byte ba = 5;

            byte x = ba + 10;
            //byte x = (byte) (ba + 10);

            ba = ba + 1;
            //ba = (byte)(ba + 1);

            ba += 1;

            // do initializtion first than do increment
            byte x1 += 10;


            // range of double is big than long type
            long l1 = 1234;
            double d1 = l1;

            double d2 = 1324;
            long l2 = d2;


            Console.WriteLine("sizeof(char)     : {0}", sizeof(char));
            Console.WriteLine("sizeof(byte)     : {0}", sizeof(byte));
            Console.WriteLine("sizeof(sbyte)    : {0}", sizeof(sbyte));
            Console.WriteLine("sizeof(float)    : {0}", sizeof(float));
            Console.WriteLine("sizeof(ushort)   : {0}", sizeof(ushort));
            Console.WriteLine("sizeof(double)   : {0}", sizeof(double));
            Console.WriteLine("sizeof(int)      : {0}", sizeof(int));
            Console.WriteLine("sizeof(long)      : {0}", sizeof(long));
            Console.WriteLine("sizeof(bool)     : {0}", sizeof(bool));
            Console.WriteLine("sizeof(short)    : {0}", sizeof(short));

            Console.ReadLine();





        }
    }
}
