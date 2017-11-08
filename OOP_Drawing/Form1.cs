using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        { 
            Square mySquare = new Square(100);
            if (mySquare is IDraw)
            {
                IDraw drawSquare = mySquare;
                drawSquare.SetLocation((int)Location.X, (int)Location.Y);
                //drawSquare.Drawing(Form1);
            }
        }
    }
}
