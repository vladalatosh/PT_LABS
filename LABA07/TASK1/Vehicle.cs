using System;

namespace Task1
{
    public class Vehicle
    {
        public string LicensePlate { get; set; }
        public double FuelTankCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelConsumption { get; set; }
        public bool IsOnTrip { get; set; }

        public Vehicle(string plate, double tankCap, double currentFuel, double consumption)
        {
            LicensePlate = plate;
            FuelTankCapacity = tankCap;
            CurrentFuel = currentFuel;
            FuelConsumption = consumption;
            IsOnTrip = false;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Номер: {LicensePlate}, Бак: {CurrentFuel}/{FuelTankCapacity}л, Расход: {FuelConsumption}л/100км]";
        }
    }
}