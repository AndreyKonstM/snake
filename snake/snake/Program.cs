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
            point p1 = new point(1,3, '*');
           // p1.x = 1;
           // p1.y = 3;
           // p1.sym = '*';

            p1.Draw();

            point p2 = new point();
            p2.x = 10;
            p2.y = 5;
            p2.sym = '#';

            p2.Draw();

            Console.ReadLine();
        }

       
    }
}
