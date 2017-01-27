using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class VerticalLine : Figure
    {
        

        public VerticalLine(int yTop, int yBotton, int x, char sym)
        {
            plist = new List<point>();
            for (int y = yTop; y <= yBotton; y++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
