using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Tower
    {
        private const int range = 1;
        private readonly MapLocation _location;
        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            int index = 0;
            // can also use for or foreach loop here
            while (index < invaders.Length)
            {
                Invader invader = invaders[index];
                if (invader.isActive &&_location.InRangeOf(invader.Location, range))
                {
                    invader.Decreasehealth(range);
                    break;
                }
                index++;
            }
        }
    }
}
