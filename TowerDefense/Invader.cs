using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        public int Health
        {
            get; private set;
        } = 2;
        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
                
        }

        public Invader(Path path)
        {
            _path = path;            
        }

        public void Move()
        {
            _pathStep += 1;
        }

        public void Decreasehealth(int factor)
        {
            Health -= factor;
        }
    }
}
