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
        private const int power = 1;
        private const double _accuracy = .75;

        private static readonly Random _random = new System.Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }
        public bool IsSuccessfulShot()
        {
            return Tower._random.NextDouble() > _accuracy;
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
                    if (IsSuccessfulShot())
                    {
                        invader.Decreasehealth(power);
                        Console.WriteLine("Shot and hit invader");
                        if (invader.isNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot and missed invader");
                    }
                    break;
                }
                index++;
            }
        }
    }
}
