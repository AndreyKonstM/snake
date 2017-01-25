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
            point p1 = new point(1, 3, '*');
            p1.Draw();

            point p2 = new point(4, 15, '#'); 
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, 'o');
            line.Drow();

            VerticalLine Line = new VerticalLine(8, 13, 4, 'o');
            Line.Drow();

            Console.ReadLine();
        }

       
    }
}
