using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract_And_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Interface******************");
            Person person = new Person();
            person.Eat();
            person.Run();
            person.Work();


            Console.WriteLine("******************Abtract*****************");
            Employee employee = new Employee();
            employee.getName();
            employee.Work();
            employee.getSalary();
            employee.Run();
            employee.Say();
             
            Student student = new Student();
            student.Work();
            student.Id_Mark();
            student.Say();
            Console.ReadKey();
        }
    }
}
