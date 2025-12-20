using System;

namespace Task1
{
    public class Truck : Vehicle, ILoadable
    {
        public bool HasTrailer { get; set; }
        public double LoadCapacity { get; set; }

        public Truck(string plate, double tankCap, double currentFuel, double consumption, bool hasTrailer, double loadCapacity)
            : base(plate, tankCap, currentFuel, consumption)
        {
            HasTrailer = hasTrailer;
            LoadCapacity = loadCapacity;
        }

        public void LoadVehicle(double amount)
        {
            if (amount > LoadCapacity)
            {
                Console.WriteLine($"[Ошибка] Грузовик перегружен! Максимум {LoadCapacity}кг.");
            }
            else
            {
                double increase = (amount / 100.0) * 1.0;
                FuelConsumption += increase;
                Console.WriteLine($"Грузовик {LicensePlate} загружен на {amount}кг. Новый расход: {FuelConsumption}л/100км.");
            }
        }
    }
}