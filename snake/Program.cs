using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '#');
            p1.Draw();

            Point p2 = new Point(4, 5, '*');
            p2.Draw();

            Point p3 = new Point(6, 7, '?');
            p3.Draw();

            Point p4 = new Point(8, 9, '/');
            p4.Draw();


            Horizontalline line = new Horizontalline(5,10, 10, '+');
            line.Drow();

            Verticalline lineV = new Verticalline(10, 10, 20, '=');
            lineV.Drow();

            Console.ReadLine();

        }
        
    }
}
