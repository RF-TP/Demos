using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReference
{
    class ParamsDemos
    {
        struct MyStruct
        {
            public int age;

            public MyStruct(int age)
            {
                this.age = age;
            }
        }

        class MyClass
        {
            public int age;

            public MyClass(int age)
            {
                this.age = age;
            }
        }

        public void Params0()
        {
            int x1 = 1;
            int x2 = x1;
            MyClass myClass1 = new MyClass(18);
            MyClass myClass2 = myClass1;

            Console.WriteLine($"Before: x1 = {x1}, x2 = {x2}, myClass1.age = {myClass1.age}, myClass2.age = {myClass2.age}");

            x2 = 2;
            myClass2.age = 14;

            Console.WriteLine($"After: x1 = {x1}, x2 = {x2}, myClass1.age = {myClass1.age}, myClass2.age = {myClass2.age}");
        }

        public void Params1()
        {
            int x = 1;
            MyClass myClass = new MyClass(18);

            //Console.WriteLine($"Before: x = {x}, myClass.age = {myClass.age}");

            ChangeInt(x);
            ChangeClass(myClass);

            Console.WriteLine($"After: x = {x}, myClass.age = {myClass.age}");
        }

        public void Params2()
        {
            MyStruct myStruct = new MyStruct(18);
            MyClass myClass = new MyClass(18);

            //Console.WriteLine($"Before: myStruct.age = {myStruct.age}, myClass.age = {myClass.age}");

            ChangeStruct(myStruct);
            ChangeClass(myClass);

            Console.WriteLine($"After: myStruct.age = {myStruct.age}, myClass.age = {myClass.age}");
        }

        public void Params3()
        {
            int x = 1;
            string str = "a";
                      

            //Console.WriteLine($"Before: x = {x}, str = {str}");

            ChangeInt(x);
            ChangeString(str);

            Console.WriteLine($"After: x = {x}, str = {str}");
        }

        public void Params4()
        {
            int x1 = 1;
            int x2 = x1;
            object obj1 = 2;
            object obj2 = obj1;

            //Console.WriteLine($"Before: x1 = {x1}, x2 = {x2}, obj1 = {obj1}, obj2 = {obj2}");

            x2 = 3;
            obj2 = 4;

            Console.WriteLine($"After: x1 = {x1}, x2 = {x2}, obj1 = {obj1}, obj2 = {obj2}");
        }

        public void Params5()
        {
            MyStruct myStruct = new MyStruct(18);
            MyClass myClass = new MyClass(18);

            //Console.WriteLine($"Before: myStruct.age = {myStruct.age}, myClass.age = {myClass.age}");

            ChangeStructNew(myStruct);
            ChangeClassNew(myClass);

            Console.WriteLine($"After: myStruct.age = {myStruct.age}, myClass.age = {myClass.age}");
        }

        void ChangeInt(int x)
        {
            x = 3;
        }

        void ChangeString(string str)
        {
            str = "b";
        }

        void ChangeStruct(MyStruct myStruct)
        {
            myStruct.age = 14;
        }

        void ChangeClass(MyClass myClass)
        {
            myClass.age = 14;
        }

        void ChangeStructNew(MyStruct myStruct)
        {
            myStruct = new MyStruct(14);
        }

        void ChangeClassNew(MyClass myClass)
        {
            myClass = new MyClass(14);
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            ParamsDemos instance = new ParamsDemos();

            string str1 = "aaaa";
            string str2 = "aaaa";

            Console.WriteLine(Object.ReferenceEquals(str1, str2));

            //instance.Params0();
            instance.Params1();
            instance.Params2();
            instance.Params3();
            //instance.Params4();
            //instance.Params5();
            Console.ReadLine();

        }
    }
}
