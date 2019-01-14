using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOverriding
{
    class BaseClass
    {

        public BaseClass()
        {
            Console.WriteLine("Base - Constructor");
        }

        public BaseClass(int x)
        {

        }
        public void Method1()
        {
            Console.WriteLine("Base - Method 1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Base - Method 2");
        }

        public void Method3()
        {
            Console.WriteLine("Base - Method 3");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived - Constructor");
        }

        public void Method1()
        {
            Console.WriteLine("Derived - Method 1");
        }

        public override void Method2()
        {
            Console.WriteLine("Derived - Method 2");
        }
    }


    class ClassA
    {
        public virtual void Method()
        {
            Console.WriteLine("Class A");
        }
    }

    class ClassB : ClassA
    {
        public override void Method()
        {
            Console.WriteLine("Class B");

            long x = 10;
            object obj = x;
            int y = (int) obj;
        }
    }

    class ClassC : ClassB
    {
        public new void Method()
        {
            Console.WriteLine("Class C");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            BaseClass derivedInstance1 = new DerivedClass();
            derivedInstance1.Method2();

            Console.ReadLine();

            BaseClass baseInstance = new BaseClass();
            DerivedClass derivedInstance = new DerivedClass();
            BaseClass derivedAsBaseInstance = new DerivedClass();

            baseInstance.Method1();
            baseInstance.Method2();
            baseInstance.Method3();

            Console.WriteLine();

            derivedInstance.Method1();
            derivedInstance.Method2();
            derivedInstance.Method3();

            Console.WriteLine();

            derivedAsBaseInstance.Method1();
            derivedAsBaseInstance.Method2();
            derivedAsBaseInstance.Method3();

            Console.WriteLine();


            ClassA classABInstance = new ClassB();
            ClassA classACInstance = new ClassC();
            ClassB classBCInstance = new ClassC();

            
            classABInstance.Method();
            classACInstance.Method();
            classBCInstance.Method();

            Console.ReadLine();


            
        }
    }
}
