using System.Collections;

namespace OOP_basics
{
    /// <remarks>
    /// В классе создается статическая хеш таблица, в которой хранятся 
    /// все созданные объекты зданий.
    /// 
    /// Метод CreateBuild в качестве аргументов получает высоту здания, количество этажей, квартир и подъездов.
    /// Номер создается автоматчиски. 
    /// На основании полученных данных метод создает объект здания, сохраняет его в хеш таблице и возвращает.
    /// 
    /// Метод DeleteBuild получает в качестве аргумента номер дома, 
    /// по нему ищет объект в хеш таблице и удаляет его. 
    /// Если объект ненайден, то возвращается null.
    /// </remarks>

    public class Creator 
    {
        private static Hashtable buildings = new Hashtable();

        public static Hashtable Buildings
        {
            get => buildings;
        }
        private Creator() { }


        public static ApartmentBuilding CreateBuild(int heightBuild,
                                                    int floorBuild,
                                                    int apartmentsNumber,
                                                    int entranceNumber)
        {
            ApartmentBuilding apartment = new ApartmentBuilding(heightBuild,
                                                                floorBuild,
                                                                apartmentsNumber,
                                                                entranceNumber);

            buildings.Add(apartment.GetBuildingNumber(), apartment);
            return apartment;
        }


        public static void DeleteBuild (int buildingNumber)
        {
            buildings.Remove(buildingNumber);
        }
    }
}
