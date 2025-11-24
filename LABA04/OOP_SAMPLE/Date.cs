namespace OOP_SAMPLE
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > 31)
                {
                    Console.WriteLine("День должен быть в диапазоне от 1 до 31.");
                }
                else
                {
                    day = value;
                }
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    Console.WriteLine("Месяц должен быть в диапазоне от 1 до 12.");
                }
                else
                {
                    month = value;
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Год не может быть отрицательным.");
                }
                else
                {
                    year = value;
                }
            }
        }

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public void AddDays(int daysToAdd)
        {
            if (daysToAdd < 0)
            {
                Console.WriteLine("Количество добавляемых дней не может быть отрицательным.");
                return;
            }

            day += daysToAdd;

            while (day > 31)
            {
                day -= 31;
                month++;
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
        }

        public void PrintDate()
        {
            Console.WriteLine($"Дата: {Day:D2}/{Month:D2}/{Year}");
        }
    }
}