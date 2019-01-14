using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{

    public class BaseClass
    {
        public void PublicMethod() { }
        private void PrivateMethod() { }
        protected void ProtectedMethod() { }
        internal void InternalMethod() { }
        internal protected void InternalProtectedMethod() { }

        private void Method()
        {
            PublicMethod();
            PrivateMethod();
            ProtectedMethod();
            InternalMethod();
            InternalProtectedMethod();
        }
    }

    public class DerivedClass : BaseClass
    {

        private  BaseClass baseInstance2 = new BaseClass();


        private void Method()
        {
            BaseClass baseInstace = new BaseClass();

        }
        


    }


    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseInstance;
            DerivedClass derivedInstance;

            
        }
    }
}
