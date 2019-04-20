using System;
using Xunit;

namespace TowerDefense.Tests
{
    public class Point
    {
        [Fact]
        public void PointTest()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);

        }
    }
}
