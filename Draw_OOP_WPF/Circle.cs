using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;

namespace Draw_OOP_WPF
{

    class Circle : IDraw, IColor
    {
        private int diameter;
        private int locX, locY;
        private Ellipse circle = null;
        public Circle(int meter)
        {
            this.diameter = meter;
        }
        void IDraw.SetLocation(int X, int Y)
        {
            this.locX = X;
            this.locY = Y;
        }
        void IDraw.Drawing(Canvas canvas)
        {
            if (this.circle != null)
            {
                canvas.Children.Remove(this.circle);
            }
            else
            {
                this.circle = new Ellipse();
            }
            this.circle.Height = this.diameter;
            this.circle.Width = this.diameter;
            Canvas.SetTop(this.circle, this.locY);
            Canvas.SetLeft(this.circle, this.locX);
            canvas.Children.Add(this.circle);
        }
        void IColor.SetColor(System.Windows.Media.Color color)
        {
            if (circle != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.circle.Fill = brush;
            }
        }
    }

}
