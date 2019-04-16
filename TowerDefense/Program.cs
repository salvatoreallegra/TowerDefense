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
            Point x = new MapLocation(4, 2);
            Point p = x;
            map.OnMap(new MapLocation(0, 0));
            Console.WriteLine(x.DistanceTo(5, 5));
            Console.Read();



        }
    }
}
