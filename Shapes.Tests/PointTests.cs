using Xunit;

namespace Shapes.Tests
{
    public class PointTests
    {
        [Fact]
        public void MoveHorisontal_10And10_15And10Returned()
        {
            Point p1 = new Point(10, 10);
            Point expected = new Point(15, 10);

            p1.MoveHorisontal(5);

            Assert.Equal(expected.Coordinates, p1.Coordinates);
        }


        [Fact]
        public void MoveVertical_10And10_10And15Returned()
        {
            Point p1 = new Point(10, 10);
            Point expected = new Point(10, 15);

            p1.MoveVertical (5);

            Assert.Equal(expected.Coordinates, p1.Coordinates);
        }
    }
}
