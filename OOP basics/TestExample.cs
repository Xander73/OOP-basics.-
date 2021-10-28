using System;


namespace OOP_basics
{
    /// <remarks>
    /// Класс TestExample в конструкторе, при помощи фабрики Creator, 
    /// создает объект типа ApartmentBuilding со всеми полями равными 1
    /// и пишет в консоль "Здание создано".
    /// 
    /// Метод Print если находит объект, то выводит информацию о нем, 
    /// если не находит, то то пишет "Здание с номером 1 не найдено".
    /// 
    /// Метод DeleteApartment удаляет созданный в конструкторе объект. 
    /// 
    /// 
    /// </remarks>
    public class TestExample
    {
        private ApartmentBuilding build;


        public TestExample()
        {
            build = Creator.CreateBuild(1, 1, 1, 1);
            Console.WriteLine("Здание создано");
        }

        public void Print ()
        {
            ApartmentBuilding tempApartment = (ApartmentBuilding)Creator.Buildings[1];
            if (tempApartment != null)
            {
                Console.WriteLine($"Здание с номером 1 найдено. В нем {tempApartment.GetApartmentsNumber()} - квартир, " +
                    $"{tempApartment.GetEntrancesNumber()} - подъездов");
            }
            else
            {
                Console.WriteLine("Здание с номером 1 не найдено");
            }            
        }


        public void DeleteApartment()
        {
            Creator.DeleteBuild(build.GetBuildingNumber());
            Console.WriteLine("Здание удалено");
        }
    }
}
