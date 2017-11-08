using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OOP_Drawing
{
    interface IDraw
    {
        void SetLocation(int X, int Y);
        void Drawing(Canvas canvas);
    }
}
