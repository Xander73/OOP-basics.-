using Xunit;

namespace OOP_basics.Tests
{
    public class CreatorTests
    {
        [Fact]
        public void CreateBuild_CreateNewApartmentBuilding_ApartmentBuildingReturned()
        {
            var actual = Creator.CreateBuild(1, 1, 1, 1);

            Assert.IsType<ApartmentBuilding> (actual);
        }


        [Fact]
        public void DeleteBuild_CreateNewBuild_1Returned()
        {
            object expected = null;

            int actual = Creator.CreateBuild(1, 1, 1, 1).GetBuildingNumber();

            Creator.DeleteBuild(actual);

            Assert.Equal (expected, Creator.Buildings[actual]);
        }
    }
}
