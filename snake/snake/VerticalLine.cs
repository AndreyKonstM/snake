using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class VerticalLine : Figure
    {
        

        public VerticalLine(int xTop, int xBotton, int x, char sym)
        {
            plist = new List<point>();
            for (int y = xTop; y <= xBotton; y++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
