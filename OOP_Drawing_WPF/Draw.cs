using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OOP_Drawing_WPF
{
    
        interface IDraw
        {
            void SetLocation(int X, int Y);
            void Drawing(Canvas canvas);
        }
        interface IColor
        {
            void SetColor(Color Color);
        }

        class Square: IDraw, IColor
        {
        private int sideLength;
        private int locX = 0, locY = 0;
        private Rectangle rect = null;
        
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
                canvas.Children.Remove(this.rect);
            }
            else
            {
                this.rect = new Rectangle();
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
    }
    class Draw {

    }

}
