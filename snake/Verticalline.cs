using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Verticalline
    {
        List<Point> plist;

        public Verticalline(int x, int yUp, int yDown, char sym)
        {
            plist = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }

        }

        public void Drow()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
