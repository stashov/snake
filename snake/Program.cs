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
            
      
            Horizontalline upline = new Horizontalline(0,78, 0, '+');
            upline.Drow();

            Horizontalline downline = new Horizontalline(0, 78, 24, '+');
            upline.Drow();

            Verticalline leftline = new Verticalline(0, 24, 0, '+');
            leftline.Drow();

            Verticalline rightline = new Verticalline(0, 24, 78, '+');
            rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();

        }
        
    }
}
