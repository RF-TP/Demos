using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    #region Task 1
    //Statement. Fix the code below.

    //interface IT1Interface
    //{
    //    void Method();
    //}

    //class T1Class : IT1Interface
    //{
    //}

    //class T1DemoClass
    //{
    //    void Method()
    //    {
    //        T1Class instance = new T1Class();
    //        instance.Method();
    //    }
    //}

    #endregion

    #region Task 2
    //Statement. Resolve the interfaces ambiguous.

    interface IT2FirstInterface
    {
        void Method1();
    }

    interface IT2SecondInterface
    {
        void Method1();
    }

    //class T2Class : IT2FirstInterface, IT2SecondInterface
    //{
    //}

    #endregion

    #region Task 3
    //Statement. Explain and show, how to get access to the methods Method1 from a Demo class method.

    interface IT3FirstInterface
    {
        void Method1();
    }

    interface IT3SecondInterface
    {
        void Method1();
    }

    //class T3Class : IT3FirstInterface, IT3SecondInterface
    //{
        
    //    {
    //        Console.WriteLine("First");
    //    }

        
    //    {
    //        Console.WriteLine("Second");
    //    }

       
        
    //}

    class T3DemoClass
    {
        void Method()
        {
        }
    }

    #endregion

    #region  Task 4
    //Statement. Find all mistakes in the code below.

    //interface Namable
    //{
    //    string name;

    //    string Name { get; set; }

    //    private void TakeName(string name);

    //    private void SayName() { Console.WriteLine("My name is " + name); }
    //}

    //class Human : Object, Namable
    //{
    //    public string Name { get; set; }

    //    void TakeName()
    //    {
    //    }
    //}


    #endregion

    class ForStudent
    {
    }
}
