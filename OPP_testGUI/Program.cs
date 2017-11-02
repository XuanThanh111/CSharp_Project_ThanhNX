using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Drawing
{ 
    class Program
    {
        interface IDraw
        {
            void SetLocation(int XCoord, int YCoord);
            void Drawing(Canvas canvas);
        }

        static void Main(string[] args)
        {
        }
    }
}
 