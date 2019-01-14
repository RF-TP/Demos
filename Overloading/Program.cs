using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    abstract class AbstractClass
    {
        abstract public int Foo();
    }


    class OverloadBasics
    {

        public int Method(int x, string str) { return 0; }

        //public int Method(int z, string anotherStr) { return 0; }  //

        //public int Method(int x, string str, int y) { return 0; } //

        //public int Method(string str, int x) { return 0; } //
   
        //public int Method(int x) { return 0; } //

        //private int Method(int x, string str) { return 0; } //

        //public string Method(int x, string str) { return ""; } //

        //public int Method(Int32 x, String str) { return 0; } //

        //public int Method(Int16 x, String str) { return 0; } //

        //public int Method(ref int x, string str) { return 0; } //

        //public int Method(out int x, string str) { x = 0; return 0; } //

    }

    class OverloadResolution
    {
        private void Method1(int x) { Console.WriteLine("Method1(int)"); }
        private void Method1(double x) { Console.WriteLine("Method1(double)"); }

        private void Method2(int x, int y) { Console.WriteLine("Method2(int, int)"); }
        private void Method2(double x, int y) { Console.WriteLine("Method2(double, int)"); }
        private void Method2(int x, double y) { Console.WriteLine("Method2(int, double)"); }

        private void Method3(double x, int y) { Console.WriteLine("Method3(double, int)"); }
        private void Method3(int x, double y) { Console.WriteLine("Method3(int, double)"); }

        private void Method4(int x, int y = 20) { Console.WriteLine("Method4(int, int)"); }
        private void Method4(int x) { Console.WriteLine("Method4(int)"); }

        private void Method5(int x, int y = 20) { Console.WriteLine("Method5(int, int)"); }
        private void Method5(double x) { Console.WriteLine("Method5(double)"); }

        private void Method6(int x) { Console.WriteLine("Method6(int)"); }
        private void Method6(double y) { Console.WriteLine("Method6(double)"); }

        private void Method7(int x) { Console.WriteLine("Method7(int)"); }
        private void Method7(double x) { Console.WriteLine("Method7(double)"); }


        public void ShowDemo()
        {
            Method1(12);
            Method2(1, 50);
            Method3(1, 50.0);
            Method4(18);
            Method5(44);
            Method6(y: 10);
            Method7(x: 10);

        }
    }

    class OverloadAdvanced
    {
        private class InternalClass { }

        void Method(object a)
        {
            Console.WriteLine("object");
        }
        void Method(object a, object b)
        {
            Console.WriteLine("object, object");
        }
        void Method(params object[] args)
        {
            Console.WriteLine("params object[]");
        }
        void Method<T>(params T[] args)
        {
            Console.WriteLine("params T[]");
        }


        public void ShowDemoClass()
        {
            Method();
            Method(null);
            Method(new InternalClass());
            Method(new InternalClass(), new InternalClass());
            Method(new InternalClass(), new object());
        }

        public void ShowDemoObject()
        {
            Method();
            Method(null);
            Method(new object());
            Method(new object(), new object());
            Method(new object(), new object(), new object());
        }

    }

    


    class Program
    {
        static void Main(string[] args)
        {
            //OverloadResolution instanceRes = new OverloadResolution();
            //instanceRes.ShowDemo();
            //Console.ReadLine();

            //OverloadAdvanced instance = new OverloadAdvanced();
            //instance.ShowDemoClass();
            //Console.WriteLine();
            //Console.ReadLine();
            //instance.ShowDemoObject();
            //Console.ReadLine();

            A a = new A();
            a.Method();

        }
    }

    class A
    {
        class MyClass
        {
            public void Method(int x)
            {

            }

            public virtual void Method(int x, int y)
            {
                var t = 1;
            }
            public virtual void Method(int x, int y, int z)
            {

            }
        }

        class MyOtherClass : MyClass
        {
            public override void Method(int x, int y, int z)
            {
                int a = 3;
            }
        }


        public void Method()
        {
            MyClass inst = new MyOtherClass();
            inst.Method(1,2,3);
            inst.Method(1,2);
        }

    }



    interface IMyInterface
    {
        int X { get; }

        void MyMeth();

    }


}
