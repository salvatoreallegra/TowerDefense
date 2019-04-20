using System;
using Xunit;
using TowerDefense;

namespace TowerDefense.Tests
{
    public class PointTests
    {
        [Fact]
        public void PointTest()
        {
            int x = 5;
            int y = 6;
            var point = new Point(x, y);
            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
            
        }
    }
}
