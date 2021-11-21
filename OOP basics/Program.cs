using System;

namespace OOP_basics
{
    public class Program
    {
        /// <remarks>
        /// В методе ниже тип TestExample из этой сборки закомментирован, 
        /// а тип из подключенной библиотеки имеет полное имя 
        /// с неймспейсом ApartmentBuildingLibrary для наглядности.
        /// 
        /// Принцип действия такой, что сперва создается тестовый объект и в нем создается обект здания, 
        /// а потом вызывается метод Print, вводящий на печать созданный объект здания.  
        /// Затем объект здания удаляется и опять выводится на пачать, чтобы понять остался объект или нет. 
        /// </remarks>
        static void Main(string[] args)
        {
            //TestExample test = new TestExample();
                        
            ApartmentBuildingLibrary.TestExample test = new ApartmentBuildingLibrary.TestExample();

            test.Print();
            test.DeleteApartment();
            test.Print();

            Console.ReadKey();

