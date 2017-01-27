using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            plist = new List<point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }

        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.Draw();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
