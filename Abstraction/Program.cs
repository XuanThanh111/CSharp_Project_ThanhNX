
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {   //Tính đóng gói
        static void Main(string[] args)
        {
            Bike objBike = new Bike();
            Console.WriteLine("Bike mileage is : " + objBike.GetMileage()); //accessible outside "Bike"
            Console.WriteLine("Bike color is : " + objBike.GetColor()); //accessible outside "Bike"
            //Chúng ta không thể gọi phương thức này từ bên ngoài "Bike"
            //objBike.GetEngineMakeFormula(); //commented because we can't access it
            Console.Read();
        }
    }
}
