namespace OOP_basics
{
    /// <remarks>
    /// Задание подразумевает проверку работы с модификаторами доступа, 
    /// поэтому проверка на корректность аргументов не проводится.
    /// </remarks>
    public class ApartmentBuilding
    {
        private static int _currentNumber;
        private int _buildingNumber;
        private int _heightBuild;
        private int _floorsBuild;
        private int _apartmentsNumber;
        private int _entrancesNumber;

        protected ApartmentBuilding () { }

        public ApartmentBuilding( int heightBuild,
                                  int florBuild,
                                  int apartmentsNumber,
                                  int entranceNumber)
        {
            SetBuildingNumber();
            _heightBuild = heightBuild;
            _floorsBuild = florBuild;
            _apartmentsNumber = apartmentsNumber;
            _entrancesNumber = entranceNumber;
        }


        public int GetBuildingNumber() => _buildingNumber;


        private void SetBuildingNumber() => _buildingNumber = ++_currentNumber;


        public int GetHeightBuild() => _heightBuild;


        public void SetHeightBuild(int heightBuild) => _heightBuild = heightBuild;


        public int GetFloorsBuild() => _floorsBuild;


        public void SetFloorsBuild(int floorsBuild) => _floorsBuild = floorsBuild;


        public int GetApartmentsNumber() => _apartmentsNumber;


        public void SetApartmentsNumber(int apartmentsNumber) => _apartmentsNumber = apartmentsNumber;


        public int GetEntrancesNumber() => _entrancesNumber;


        public void SetEntrancesNumber(int entrancesNumber) => _entrancesNumber = entrancesNumber;


        public int HeightFloor() => GetHeightBuild() / GetFloorsBuild();


        public int ApartmensInEntrance() => GetApartmentsNumber() / GetEntrancesNumber();


        public int ApartmentsPerFloor() => ApartmensInEntrance() / GetFloorsBuild();
    }
}
