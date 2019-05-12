/*Author: Salvatore Allegra
 * Utility class for generating random numbers of type double 
 *  
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    static class Random
    {
        private static System.Random _random = new System.Random();

        public static Double NextDouble()
        {
            return _random.NextDouble();
        }
    }
}
