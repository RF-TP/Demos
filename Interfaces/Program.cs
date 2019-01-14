using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    #region Interface sealed problem 
    //Question is: What will happen if I define the class as sealed?

    interface ISomeInterface { }   
    
    class SomeClass { }

    class ErrorDemo
    {
        public void Method()
        {
            SomeClass classInstance = new SomeClass();
            //ISomeInterface interfaceInstance1 = classInstance;
            ISomeInterface interfaceInstance2 = (ISomeInterface)classInstance;
            Console.WriteLine("I'm OK");
        }
    }

    #endregion

    #region Blank method question
    //Question. Whether a blank method is a correct implementation of the corresponding interface method?
    interface IMyInterface
    {
        void Method();
    }

    //class SomeOtherClass : IMyInterface
    //{
    //    public void Method() { }
    //}
    #endregion

    #region Mixed inheritance
    //Question. Can a class be inherited from another class and an interfare at the same time?

    //interface IMyThirdInterface
    //{
    //}

    //class MyA
    //{

    //}

    //class MyB : IMyThirdInterface, MyA
    //{ }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //T3Class myClassInstance = new T3Class();

            ErrorDemo errDemo = new ErrorDemo();
            errDemo.Method();

            Console.ReadLine();

        }
    }


    interface IInt1 { void Method(); }

    interface IInt2 { void Method(); }

    class DemoClass : IInt1, IInt2
    {
        void IInt1.Method()
        {

        }

        void IInt2.Method()
        {

        }


    }


}
