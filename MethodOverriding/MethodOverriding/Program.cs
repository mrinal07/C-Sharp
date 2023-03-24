using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class DemoMethodOverriding
    {
        public void Display()
        {
            Console.WriteLine("DemoMethodOverriding Class Display method");
        }

        public virtual void Show()
        {
            Console.WriteLine("DemoMethodOverriding Class Show method");
        }

    }

    class Child : DemoMethodOverriding
    {
        public void Display()
        {
            base.Display();
            Console.WriteLine("Child Class Display method");
        }

        override public void Show()
        {
            Console.WriteLine("Child Class Show method");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Child child= new Child();
            child.Display();
            child.Show();
            Console.ReadLine();
        }
    }
}
