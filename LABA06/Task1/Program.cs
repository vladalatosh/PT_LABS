using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[10];

            zoo[0] = new Mammal("Лев", 8, 190.5, "Саванна", true, "Золотистый");
            zoo[1] = new Bird("Попугай", 2, 0.5, "Тропики", false, 0.3);
            zoo[2] = new Fish("Акула", 15, 600, "Океан", true, true);
            zoo[3] = new Reptile("Змея", 4, 3.2, "Джунгли", true, false);
            zoo[4] = new Insect("Бабочка", 1, 0.01, "Луг", false, 6);
            zoo[5] = new Mammal("Слон", 25, 5000, "Саванна", false, "Серый");
            zoo[6] = new Bird("Орел", 5, 4.5, "Горы", true, 2.1);
            zoo[7] = new Reptile("Черепаха", 80, 50, "Острова", false, true);
            zoo[8] = new Mammal("Волк", 6, 45, "Лес", true, "Серый");
            zoo[9] = new Fish("Карась", 3, 0.4, "Озеро", false, false);

            Console.WriteLine("--- Все животные в зоопарке ---");
            foreach (var animal in zoo)
            {
                animal.ShowInfo();
                animal.MakeSound();
            }
            Console.WriteLine();
            double totalPredatorAge = 0;
            int predatorCount = 0;

            foreach (var animal in zoo)
            {
                if (animal.IsPredator)
                {
                    totalPredatorAge += animal.Age;
                    predatorCount++;
                }
            }

            if (predatorCount > 0)
            {
                double averageAge = totalPredatorAge / predatorCount;
                Console.WriteLine($"Средний возраст хищников: {averageAge:F1} лет");
            }
            else
            {
                Console.WriteLine("Хищников в зоопарке нет.");
            }
            Animal heaviestPredator = null;
            double maxWeight = -1;

            foreach (var animal in zoo)
            {
                if (animal.IsPredator)
                {
                    if (animal.Weight > maxWeight)
                    {
                        maxWeight = animal.Weight;
                        heaviestPredator = animal;
                    }
                }
            }

            if (heaviestPredator != null)
            {
                Console.WriteLine($"Самый тяжелый хищник: {heaviestPredator.Species} (Вес: {heaviestPredator.Weight} кг)");
            }

            Console.ReadLine();
        }
    }
}