namespace OOP_SAMPLE
{
    public class AProgression
    {
        public int first;
        public int step;
        public AProgression(int first, int step)
        {
            this.first = first;
            this.step = step;
        }
        public int GetSum(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Количество членов прогрессии должно быть положительным.");
                return 0;
            }
            return n / 2 * (2 * first + (n - 1) * step);
        }
        public void PrintFirstN(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Количество членов прогрессии должно быть положительным.");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(first + i * step + " ");
            }
            Console.WriteLine();
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Арифметическая прогрессия: первый член = {first}, шаг = {step}");
        }
    }
}