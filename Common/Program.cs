using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class ConstantsVSReadOnlyDemo
    {
        const int constant = 1;
        readonly int readOnly = 1;

        public ConstantsVSReadOnlyDemo()
        {
        //    constant = 2;
        //    readOnly = 2;
        }

        void Change()
        {
            //constant = 2;
            //readOnly = 2;
        }

        public void Show()
        {
            Console.WriteLine($"constant = {constant}, readOnly = {readOnly}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////TetsBU();
            //ConstantsVSReadOnlyDemo instance = new ConstantsVSReadOnlyDemo();
            //instance.Show();
            //Console.ReadLine();


            A instance = new B();
            instance.Method();
            Console.ReadLine();

        }

        static void BoxingUnboxing()
        {
            object obj = new object();
            int x = 3;
            obj = x;
            int y = (int)obj;
        }
    }





    class A
    {
        public virtual void Method()
        {
            Console.WriteLine("A");

        }

    }

    class B : A
    {
        public override void Method()
        {
            Console.WriteLine("B");
        }
    }



}
