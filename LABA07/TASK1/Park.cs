using System;
using System.Collections.Generic;

namespace Task1
{
    public class Park
    {
        public List<Vehicle> Vehicles { get; set; }

        public Park()
        {
            Vehicles = new List<Vehicle>();
        }

        public void AddToPark(Vehicle v)
        {
            if (Vehicles.Count >= 5)
            {
                Console.WriteLine($"[Парк] Ошибка: Автопарк переполнен (максимум 5). Не добавлен: {v.LicensePlate}");
                return;
            }

            if (v is Motorcycle)
            {
                int motoCount = 0;
                foreach (var item in Vehicles)
                {
                    if (item is Motorcycle) motoCount++;
                }

                if (motoCount >= 1)
                {
                    Console.WriteLine($"[Парк] Ошибка: В парке уже есть мотоцикл. Не добавлен: {v.LicensePlate}");
                    return;
                }
            }

            Vehicles.Add(v);
            Console.WriteLine($"[Парк] Транспорт {v.LicensePlate} успешно добавлен.");
        }

        public void RemoveFromPark(Vehicle v)
        {
            if (Vehicles.Contains(v))
            {
                Vehicles.Remove(v);
                Console.WriteLine($"[Парк] Транспорт {v.LicensePlate} удален из парка.");
            }
            else
            {
                Console.WriteLine("[Парк] Такого транспорта нет в списке.");
            }
        }

        public void SendToRace(Vehicle v, double distance)
        {
            if (!Vehicles.Contains(v))
            {
                Console.WriteLine("[Рейс] Ошибка: Этой машины нет в автопарке.");
                return;
            }

            if (v.IsOnTrip)
            {
                Console.WriteLine($"[Рейс] Машина {v.LicensePlate} уже находится на выезде!");
                return;
            }

            v.IsOnTrip = true;
            Console.WriteLine($"[Рейс] Машина {v.LicensePlate} отправлена в рейс на {distance} км.");

            double fuelNeeded = (distance / 100.0) * v.FuelConsumption;

            if (v.CurrentFuel >= fuelNeeded)
            {
                Console.WriteLine($"   -> Топлива достаточно. Потратится {fuelNeeded:F2} л. Останется {(v.CurrentFuel - fuelNeeded):F2} л.");
            }
            else
            {
                double shortage = fuelNeeded - v.CurrentFuel;
                Console.WriteLine($"   -> ВНИМАНИЕ: Топлива не хватит! Нужно дозаправить: {shortage:F2} л.");
            }
        }

        public override string ToString()
        {
            string result = "\n--- Список свободных машин в автопарке ---\n";
            bool isEmpty = true;

            foreach (var v in Vehicles)
            {
                if (!v.IsOnTrip)
                {
                    result += v.ToString() + "\n";
                    isEmpty = false;
                }
            }

            if (isEmpty) return result + "Нет свободных машин.\n";
            return result;
        }
    }
}