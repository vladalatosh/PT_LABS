using System;

namespace Task1
{
    public class CompanyCar : Vehicle, ILoadable
    {
        public int NumberOfSeats { get; set; }
        public double LoadCapacity { get; set; }

        public CompanyCar(string plate, double tankCap, double currentFuel, double consumption, int seats, double loadCapacity)
            : base(plate, tankCap, currentFuel, consumption)
        {
            NumberOfSeats = seats;
            LoadCapacity = loadCapacity;
        }

        public void LoadVehicle(double amount)
        {
            if (amount > LoadCapacity)
            {
                Console.WriteLine($"[Ошибка] Нельзя загрузить {amount}кг. Максимум {LoadCapacity}кг.");
            }
            else
            {
                double increase = (amount / 100.0) * 0.5;
                FuelConsumption += increase;
                Console.WriteLine($"Автомобиль {LicensePlate} загружен на {amount}кг. Новый расход: {FuelConsumption}л/100км.");
            }
        }
    }
}