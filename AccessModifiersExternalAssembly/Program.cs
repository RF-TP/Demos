using AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExternalAssembly
{

    class Program
    {

        static void Main(string[] args)
        {
            BaseClass baseInstance;
            DerivedClass derivedInstance;
        }
    }








































































    class ExternalDerivedFromBase : BaseClass
    {
        private void Method()
        {
        }
    }

    class ExternalDerivedFromDerived : DerivedClass
    {
        private void Method()
        {
        }
    }

}
