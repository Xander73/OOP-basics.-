using Xunit;

namespace _7_Lesson.Tests
{
    public class CircleTests
    {
        [Fact]
        public void MoveHorisontal_10And10_15And10Returned()
        {
            Circle c1 = new Circle(10, 10, 5);
            Circle expected = new Circle(15, 10, 5);

            c1.MoveHorisontal(5);

            Assert.Equal(expected.Coordinates, c1.Coordinates);
        }


        [Fact]
        public void MoveVertical_10And10_10And15Returned()
        {
            Circle c1 = new Circle(10, 10, 5);
            Circle expected = new Circle(10, 15, 5);

            c1.MoveVertical(5);

            Assert.Equal(expected.Coordinates, c1.Coordinates);
        }


        [Fact]
        public void Areal_5Radius_78_5Returned()
        {
            Circle c1 = new Circle(10, 10, 5);
            double expected = 3.14*5*5;

            var actual = c1.Areal();

            Assert.Equal(expected, actual);
        }
    }
}
