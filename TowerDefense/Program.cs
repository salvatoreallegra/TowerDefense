using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8,5);
            int area = map.Width * map.Height;

            Point point = new Point(4, 2);
            Console.WriteLine(point.DistanceTo(5, 5));
            Console.Read();



        }
    }
}
