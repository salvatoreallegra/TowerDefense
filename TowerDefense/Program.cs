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
            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);            }



        }
    }
}
