using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Text;
using System.Windows.Media;
namespace OOP_Drawing
{
    interface IDraw
    {
       
        void SetLocation(int z, int a);
        void Draw( canvas );
    }
    interface IColor
    {
        void Color(System.Drawing.Color Color);
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
