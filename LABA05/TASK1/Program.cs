
namespace TASK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование класса Fraction\n");

            Fraction f1 = new Fraction(5, 250);

            Fraction f2 = new Fraction(2, 750);

            Fraction fres = f1 + f2;

            Console.WriteLine(fres);

            Console.WriteLine($"Дробь 1: {f1}");
            Console.WriteLine($"Дробь 2: {f2}");

            Console.WriteLine($"\nЦелая часть F1: {f1.WholePart}");
            f1.FractionalPart = 300; 
            Console.WriteLine($"F1 после изменения дробной части на 300: {f1}");

            f1.FractionalPart = 250;

            Console.WriteLine("\n--- Арифметика ---");

            Fraction sum = f1 + f2;
            Console.WriteLine($"{f1} + {f2} = {sum}");

            Fraction diff = f1 - f2;
            Console.WriteLine($"{f1} - {f2} = {diff}");

            Fraction prod = f1 * f2;
            Console.WriteLine($"{f1} * {f2} = {prod}");

            Fraction div = f1 / f2;
            Console.WriteLine($"{f1} / {f2} = {div}");

            Console.WriteLine("\n--- Сравнение ---");
            Fraction f3 = new Fraction(5, 250); 

            bool areEqual = f1.Equals(f3);
            Console.WriteLine($"F1 ({f1}) равно F3 ({f3})? -> {areEqual}");

            bool areEqual2 = f1.Equals(f2);
            Console.WriteLine($"F1 ({f1}) равно F2 ({f2})? -> {areEqual2}");

            Console.ReadKey();
        }
    }
}
