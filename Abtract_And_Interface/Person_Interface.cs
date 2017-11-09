using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract_And_Interface
{
    /***********************************************/
    //interface không có thân hàm;
    //không cho phép khai báo Feild
    //Class triển khai có thể triển khai nhiều interface.
    //Không chứa constructor
    //Các phương thức không có từ khóa access modifier
    /***********************************************/
    interface IRunable
    {
        void Run();
    }
    interface IWorkable
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    class Person : IRunable, IWorkable, IEat
    {
        public void Eat()
        {
            Console.WriteLine("I can't Eat");
        }

        public void Run()
        {
            Console.WriteLine("I can Run");

        }

        public void Work()
        {
            Console.WriteLine("I can Work");
        }
    }
}
