using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract_And_Interface
{
    /*************************************************/
    //abtract có thể có thân hàm hoặc không
    //Cho phép khai báo Feild:  pulic, protected.....
    //Class dẫn xuất chỉ kế thừa được từ 1 abstract class và nhiều interface
    //Có chứa constructor
    //Các phương thức không có từ khóa access modifier : private
    //protected
    //internal
    //protected internal
    //public
        /*************************************************/
        abstract class Person_abtract
    {
        protected string name="Thanh"; //=>field 
        protected string birthDay;
        public void Say()
        {
            Console.WriteLine("I love you......");
        }
        public abstract void Work();

    }

    class Employee : Person_abtract,IRunable
    {
        private int salary=1000;

        public override void Work()
        {

            Console.WriteLine("I am working.....");
        }
        public void getName()
        {
            Console.WriteLine("I'm: " + name);
        }
        
        public void getSalary()
        {
            Console.WriteLine("I have salary= " + salary +" $");
        }

        public void Run()
        {
            Console.WriteLine("Employee can run very fast");
        }
    }

    class Student : Person_abtract
    {
        private int mark=20152675;
        public override void Work()
        {
            Console.WriteLine("I am studying....");

        }
        public void Id_Mark()
        {
            Console.WriteLine("I have ID: " + mark);
        }
       
    }
}
