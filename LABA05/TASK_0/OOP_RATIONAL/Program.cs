using System;

namespace OOP_RATIONAL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Rational r1 = new Rational(4, 8);   
                Rational r2 = new Rational(2, -5);  
                Rational r3 = new Rational(-3, -4); 
                
                Console.WriteLine("--- Исходные дроби (после сокращения) ---");
                Console.WriteLine($"R1: {r1}");
                Console.WriteLine($"R2: {r2}");
                Console.WriteLine($"R3: {r3}");

                
                Console.WriteLine("\n--- Арифметика ---");
                Rational sum = r1 + r2;
                Rational sub = r2 - r3;
                Rational mult = r1 * r3;
                Rational div = r2 / r1;

                Console.WriteLine($"{r1} + {r2} = {sum}");
                Console.WriteLine($"{r2} - {r3} = {sub}");
                Console.WriteLine($"{r1} * {r3} = {mult}");
                Console.WriteLine($"{r2} / {r1} = {div}");

                
                Console.WriteLine("\n--- Сложное выражение ---");
                
                Rational complex = r1 + r2 * r3; 
                Console.WriteLine($"{r1} + {r2} * {r3} = {complex}");

                
                Console.WriteLine("\n--- Сравнение ---");
                Console.WriteLine($"{r1} > {r2} : {r1 > r2}");
                Console.WriteLine($"{r1} == {new Rational(1, 2)} : {r1 == new Rational(1, 2)}");
                Console.WriteLine($"{r2} != {r3} : {r2 != r3}");

                
                Console.WriteLine("\n--- Тест ошибки деления на 0 ---");
                Rational zeroNumerator = new Rational(0, 5); 
                
                
                Rational errorCheck = r1 / zeroNumerator; 
                Console.WriteLine(errorCheck);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"\nОШИБКА: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nНЕИЗВЕСТНАЯ ОШИБКА: {e.Message}");
            }
        }
    }
}