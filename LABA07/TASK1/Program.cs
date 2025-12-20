using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Система управления автопарком ===\n");

            Park myPark = new Park();

            Motorcycle moto1 = new Motorcycle("MOTO-01", 15, 10, 5, false);
            CompanyCar car1 = new CompanyCar("CAR-01", 50, 45, 8, 4, 500);
            CompanyCar car2 = new CompanyCar("CAR-02", 60, 20, 9, 4, 500);
            Truck truck1 = new Truck("TRUCK-01", 200, 150, 25, true, 5000);
            Truck truck2 = new Truck("TRUCK-02", 200, 50, 30, false, 8000);
            
            Motorcycle moto2 = new Motorcycle("MOTO-ERR", 15, 15, 5, true);
            CompanyCar carExtra = new CompanyCar("CAR-EXTRA", 40, 40, 7, 2, 300);

            Console.WriteLine("1. Заполнение автопарка:");
            myPark.AddToPark(moto1);
            myPark.AddToPark(car1);
            myPark.AddToPark(car2);
            myPark.AddToPark(truck1);
            myPark.AddToPark(truck2); 
            myPark.AddToPark(moto2);
            myPark.AddToPark(carExtra); 

            Console.WriteLine("\n2. Загрузка транспорта:");
            Console.WriteLine($"Расход до загрузки: {truck1.FuelConsumption}");
            truck1.LoadVehicle(2000); 

            Console.WriteLine("\n3. Отправка в рейс:");
            myPark.SendToRace(car1, 200);
            myPark.SendToRace(car2, 500);

            Console.WriteLine("\n4. Свободные машины:");
            Console.WriteLine(myPark.ToString());

            Console.ReadLine();
        }
    }
}