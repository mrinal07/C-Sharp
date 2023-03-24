using LogSaveLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class DemoEncapsulation
    {
        int _id;
        string _name;

        public void setData(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return _id + " " + _name;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> log = new List<string>(); 
            try
            {
                log.Add("--------------------------------------");
                log.Add("Inside Encapsulation Program.cs Main()");
                log.Add("Process started at " + DateTime.Now);

                DemoEncapsulation demo = new DemoEncapsulation();
                log.Add("DemoEncapsulation object demo created");

                demo.setData(52, "Mrinal");
                log.Add("demo.setData() called");

                Console.WriteLine(demo);
                log.Add("Print the object of class DemoEncapsulation");

                Console.ReadKey();

            }
            catch (Exception e)
            {
                log.Add("Inside catch{} "+e);

                throw;
            }
            finally 
            { 
                log.Add("Inside finally{} ");
                log.Add("Process ended at " + DateTime.Now);
                SaveLog.WriteLogs2(log, "Encapsulation");

            }

            

            // For understanding Debugging
            //char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
            //string name = "";
            //int[] a = new int[10];
            //for (int i = 0; i < letters.Length; i++)
            //{
            //    name += letters[i];
            //    a[i] = i + 1;
            //    SendMessage(name, a[i]);
            //}

            //TEMP();
            

        }
        // For understanding Debugging
        //static void SendMessage(string name, int msg)
        //{
        //    Console.WriteLine("Hello, " + name + "! Count to " + msg);
        //}

        static void TEMP()
        {

            //Doubt                
            char ch = Convert.ToChar('a' | 'b' | 'c' | 's');

            Console.WriteLine(ch);

            switch (ch)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("case A | case a");
                    break;

                case 'B':
                case 'b':
                    Console.WriteLine("case B | case b");
                    break;

                case 'C':
                case 'c':
                case 'D':
                case 'd':
                    Console.WriteLine("case D | case d");
                    break;
            }
            Console.Read();

        }
    }
}
