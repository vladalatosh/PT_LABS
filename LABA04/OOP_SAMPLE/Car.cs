using System.Collections.Concurrent;

namespace OOP_SAMPLE
{
    public class Car
    {
        public string mark;
        public string model;
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1886 || value > 2025)
                {
                    Console.WriteLine($"Год выпуска должен быть в диапазоне от 1886 до 2025.");
                }
                else
                {
                    year = value;
                }
            }
        }
        public Car(string mark, string model, int year)
        {
            this.mark = mark;
            this.model = model;
            this.Year = year;
        }

        public int GetCarAge()
        {
            return 2025 - Year;
        }

        public bool IsVintage()
        {
            return GetCarAge() > 25;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Car: {mark} {model}, Year: {Year}, Age: {GetCarAge()} years, Vintage: {IsVintage()}");
        }
    }
}