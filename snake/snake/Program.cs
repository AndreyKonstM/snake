using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, 'x');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, 'x');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, 'x');
            VerticalLine righttLine = new VerticalLine(0, 24, 78, 'x');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            righttLine.Drow();


            point p = new point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }

       
    }
}
