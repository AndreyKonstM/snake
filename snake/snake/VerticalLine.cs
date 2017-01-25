using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class VerticalLine
    {
        List<point> plist;

        public VerticalLine(int xTop, int xButton, int x, char sym)
        {
            plist = new List<point>();
            for (int y = xTop; y <= xButton; y++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }
        }

        public void Drow()
        {
            foreach (point p in plist)
            {
                p.Draw();
            }
        }
    }
}
