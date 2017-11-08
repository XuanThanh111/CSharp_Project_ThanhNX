using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Draw_OOP_WPF
{
    class Square : IDraw, IColor
    {
        private int sideLength;
        private int locX = 0, locY = 0;
        private System.Windows.Shapes.Rectangle rect = null;

        public Square(int sideLength)
        {
            this.sideLength = sideLength;
        }
        void IDraw.SetLocation(int X, int Y)
        {
            this.locX = X;
            this.locY = Y;
        }
        void IDraw.Drawing(Canvas canvas)
        {
            if (this.rect != null)
            {
                canvas.Children.Remove(rect);
            }
            else
            {
                this.rect = new System.Windows.Shapes.Rectangle();
            }
            this.rect.Height = this.sideLength;
            this.rect.Width = this.sideLength;
            Canvas.SetTop(this.rect, this.locY);
            Canvas.SetLeft(this.rect, this.locX);
            canvas.Children.Add(this.rect);
        }
        void IColor.SetColor(Color color)
        {
            if (this.rect != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.rect.Fill = brush;
            }
        }
        public void Drawing(Canvas canvas)
        {
            throw new NotImplementedException();
        }

        public void SetColor(Color Color)
        {
            throw new NotImplementedException();
        }
    }
}
