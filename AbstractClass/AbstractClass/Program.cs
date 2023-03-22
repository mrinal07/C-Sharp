using LogSaveLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //an abstract class is an incomplete class or a special class
    //we can’t be instantiated. The purpose of an abstract class
    //is to provide a blueprint for derived classes and set some
    //rules that the derived classes must implement when they inherit
    //an abstract class. We can use an abstract class as a base class
    //and all derived classes must implement abstract definitions.


    //The virtual keyword in C# is used to override the base class member
    //in its derived class based on the requirement. A virtual keyword is
    //used to specify the virtual method in the base class and the method
    //with the same signature that needs to be overridden in the derived class
    //is preceded by override keyword

    

    abstract class Parent
    {
        // Abstract data type
        public abstract string Name { get; set; }

        // Abstract method
        public abstract string Description(string msg);

        // Non-Abstract method
        public string getName()
        {
            return Name;
        }

        // virual method
        public virtual void display()
        {
            Console.WriteLine("From Parent Class ");

            // if base class virtual method has some error then program execution will stop there until.
            // for this exception handling must be used

            try
            {
                int x = 10;
                int b = 0;

                Console.WriteLine(x / b);
            }
            catch(Exception e)
            { 
                Console.WriteLine(e.Message);
            }   

        }
    }

    class Child : Parent
    {
        public override string Name { get; set; }

        public override string Description(string msg)
        {
            return msg;
        }

        public override void display() 
        {
            base.display();
            Console.WriteLine("From Child Class");
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
                log.Add("Inside AbstractClass Program.cs Main()");
                log.Add("Process started at " + DateTime.Now);

                Child c = new Child();
                log.Add("Child object c created ");

                Console.WriteLine(c.Description("Hello from Main method."));

                c.display();
                log.Add("c.display() called");
                log.Add("Process ended at " + DateTime.Now);
            }
            catch (Exception e)
            {
                log.Add("Inside catch{} "+e);

                throw;
            }
            finally
            {
                log.Add("Inside finally{} ");

                //SaveLog.WriteLogs(log, "AbstractClass");

                SaveLog.WriteLogs2(log, "AbstractClass");

                
            }

            Console.Read();
        }
    }
}
