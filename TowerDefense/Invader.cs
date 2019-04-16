using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        private int _pathStep = 0;
        public MapLocation Location { get; private set; }

        public Invader(Path path)
        {
            Location = path.GetLocationAt(0);
        }

        public void Move()
        {
            _pathStep += 1;
        }
    }
}
