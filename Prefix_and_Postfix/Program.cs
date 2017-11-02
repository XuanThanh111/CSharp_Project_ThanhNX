using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefix_and_Postfix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 9;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("test Prefix:" + a++);
                Console.WriteLine("test Postfix:" + ++b);
            }

            Console.WriteLine("********************************");

            a = 9;
            b = 9;
            for (int i = 0; i < 3; ++i)
            {                
                Console.WriteLine("test Prefix:" + a++);
                Console.WriteLine("test Postfix:"+ ++b);
            }
            Console.ReadKey();
        }
    }
}
