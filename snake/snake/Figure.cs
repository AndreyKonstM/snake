using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Figure
    {
       protected List<point> plist;

        public virtual void Draw()
        {
            foreach (point p in plist)
            {
                p.Draw();
            }
        }
    }
}
