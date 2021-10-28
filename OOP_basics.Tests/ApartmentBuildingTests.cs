using Xunit;

namespace OOP_basics.Tests
{
    public class ApartmentBuildingTests
    {
        ApartmentBuilding build = Creator.CreateBuild(30, 10, 160, 4);


        [Fact]
        public void HeightFloor_3Returned()
        {
            int expected = 3;

            int actual = build.HeightFloor();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ApartmensInEntrance_40Returned()
        {
            int expected = 40;

            int actual = build.ApartmensInEntrance();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ApartmentsPerFloor_4Returned()
        {
            int expected = 4;

            int actual = build.ApartmentsPerFloor();

            Assert.Equal(expected, actual);
        }
    }
}
