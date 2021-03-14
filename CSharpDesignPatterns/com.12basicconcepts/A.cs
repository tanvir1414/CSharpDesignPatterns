using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._12basicconcepts
{
    interface IA
    {
        void MethodA();
    }

    class A
    {
        public virtual void MethodA()
        {
            Console.WriteLine("A-MA");
        }
    }

    class B : A,IA
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

            // cannot call b object
            

            Console.WriteLine("-------");
            Console.WriteLine("Casting");
            ((B)obj1).MethodA(); //calling b object
            (obj1 as B).MethodB();

            IA obj3;
            obj3 = new B();
            obj3.MethodA();
            

            //cannot do this
            //B obj2 = new A();

        }

    }
}
