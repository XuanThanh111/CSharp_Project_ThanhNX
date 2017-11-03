using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Shapes;
namespace OOP_Drawing
{
    interface IDraw
    {
        void SetLocation(int X, int Y);
        void Drawing(Canvas canvas);
    }
    interface IColor
    {
        void SetColor(System.Windows.Media.Color Color);
    }

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
                canvas.Children.Remove(this.rect);
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
        void IColor.SetColor(System.Windows.Media.Color color)
        {
            if (this.rect != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.rect.Fill = brush;
            }
        }
    }

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


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
