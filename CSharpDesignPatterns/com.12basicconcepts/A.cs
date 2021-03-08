using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._12basicconcepts
{
    class A
    {
        public virtual void MethodA()
        {
            Console.WriteLine("A-MA");
        }
    }

    class B :A
    {
        public override void MethodA()
        {
            Console.WriteLine("B-MA");
        }
        public void MethodB()
        {
            Console.WriteLine("B-MB");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            A aobj = new A();
            aobj.MethodA();
            B bobj = new B();
            bobj.MethodA();
            bobj.MethodB();

            Console.WriteLine("A or B?");
            // Superclass obj = new Subclass();
            int x= 10;
            //A Object only
            A obj1 = new B();
            obj1.MethodA();

            //why cannot call b object
            

            Console.WriteLine("-------");
            ((B)obj1).MethodA();
            (obj1 as B).MethodB();



            //cannot do this
            //B obj2 = new A();

        }

    }
}
