using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        private MapLocation _location;

      
        public MapLocation Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
                Console.WriteLine("Location Changed");
            }
        }
    }
}
