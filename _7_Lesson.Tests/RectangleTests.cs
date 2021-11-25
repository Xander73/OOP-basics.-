using Xunit;

namespace _7_Lesson.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void MoveHorisontal_10And10_15And10Returned()
        {
            Rectangle r1 = new Rectangle(10, 10, 5, 5);
            Rectangle expected = new Rectangle(15, 10, 5, 5);

            r1.MoveHorisontal(5);

            Assert.Equal(expected.Coordinates, r1.Coordinates);
        }


        [Fact]
        public void MoveVertical_10And10_10And10Returned()
        {
            Rectangle r1 = new Rectangle(10, 10, 5, 5);
            Rectangle expected = new Rectangle(10, 15, 5, 5);

            r1.MoveVertical(5);

            Assert.Equal(expected.Coordinates, r1.Coordinates);
        }


        [Fact]
        public void Areal_5Width10Height_Returned()
        {
            Rectangle r1 = new Rectangle(10, 10, 5, 10);
            double expected = 5 * 10;

            var actual = r1.Areal();

            Assert.Equal(expected, actual);
        }
    }
}
