using System;

namespace Task1
{
    public interface ILoadable
    {
        double LoadCapacity { get; set; } // Грузоподъемность
        void LoadVehicle(double amount);  // Метод загрузки
    }
}