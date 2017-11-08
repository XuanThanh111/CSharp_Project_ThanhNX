using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Draw_OOP_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawingCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mouseLocation = e.GetPosition(this.drawingCanvas);
            Random random =new Random();
            Square mySquare = new Square(random.Next(1,100));
            if (mySquare is IDraw)
            {
                IDraw drawSquare = mySquare;
                drawSquare.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
                drawSquare.Drawing(drawingCanvas);
            }
            if (mySquare is IColor)
            {
                IColor colorSquare = mySquare;
                colorSquare.SetColor(Colors.BlueViolet);
            }
        }

        private void drawingCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mouseLocation = e.GetPosition(this.drawingCanvas);
            Random random = new Random();
            Circle myCircle = new Circle(random.Next(1,100));
            if (myCircle is IDraw)
            {
                IDraw drawCircle = myCircle;
                drawCircle.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
                drawCircle.Drawing(drawingCanvas);
            }
            if (myCircle is IColor)
            {
                IColor colorCircle = myCircle;
                colorCircle.SetColor(Colors.HotPink);
            }
        }
    }
}
