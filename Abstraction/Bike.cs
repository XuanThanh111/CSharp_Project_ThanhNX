using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Bike
    {
        public int mileage = 65;
        public string color = "Black";
        private string formula = "a*b";

        public int GetMileage()
        {
            return mileage;
        }
        public string GetColor()
        {
            return color;
        }
        //private khong duoc truy xuat ben ngoai class
        private string GetEngineMakeFormula()
        {
            return formula;
        }
    }
}
