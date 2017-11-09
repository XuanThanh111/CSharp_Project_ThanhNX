using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out
{
    class Program
    {
        static void doIncrement(ref int param)
        {
            param++;
        }
        static void doInitialize(out int param)
        {
            param = 99; //Initialize param before finishing
        }
        static void Main(string[] args)
        {
            int arg = 21;
            doIncrement(ref arg);
            Console.WriteLine(arg); //==> arg=22;
            int arg2;
            //  doIncrement(ref arg2); => cannot initialize because arg2 have to given


            doInitialize(out arg2);
            Console.WriteLine(arg2);
            Console.ReadKey();
        }
    }
}
