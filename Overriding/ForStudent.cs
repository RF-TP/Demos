using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOverriding
{
    #region Task 1
    //Statement. Define a class, then define another class, which will be inherited from the firs one.

        class A
    {
        int a;

    }
    class B : A { int b; }


    #endregion

    #region Task 2
    //Statement. You have derived class with the same method as it's parent class.
    //  1) Explainb the "new" modifyer.
    //  2) Modify the code below so that the Method is overridden.


    class T2Base
    {
        public virtual void Method()
        {

        }
    }

    class T2Derived : T2Base
    {
        public override void Method()
        {

        }
    }


    #endregion

    #region Task 3
    //Statement. You have the following classes.
    //  1) Modify the code below so that the Base class cannot be inherited from.
    //  2*) Do point 1 without any CLASS modifyers.

     class  T3Base
    {
        public void Method()
        {

        }
        //private T3Base() { }
    }

    class T3Derived : T3Base
    {
        public new void Method()
        {

        }
    }



    #endregion

    #region Task 4 
    //Statement. Answer the question: which of the following overriddings are allowed?

    class T4Base
    {
        protected virtual void Metod()
        {

        }

    }

    class T4Derived : T4Base
    {
    //    public override void Metod()
    //    {
    //    }

        //protected override void Metod()
        //{
        //}

        //private override void Metod()
        //{
        //}

        //internal override void Method()
        //{

        //}
    }

    #endregion





    class ForStudent
    {
    }
}
