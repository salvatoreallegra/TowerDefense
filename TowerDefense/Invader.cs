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

        public MapLocation GetLocation()
        {
            return _location;
        }
        public void SetLocation(MapLocation value)
        {
            _location = value;
        }
    }
}
