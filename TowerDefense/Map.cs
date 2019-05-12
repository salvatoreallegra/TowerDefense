/*Author: Salvatore Allegra
 * The Map class defines a map for a game,
 * it's the canvas that contains points, towers and invaders.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width &&
                   point.Y >= 0 && point.Y < Height;
        }
    }
}
