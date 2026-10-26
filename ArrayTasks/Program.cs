using System;
using System.Linq;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Вариант 1:");
            int[] B1 = Enumerable.Range(0, 15).Select(x => rnd.Next(-20, 21)).ToArray();
            int countPos1 = B1.Count(x => x > 0);
            int sumOdd1 = B1.Where(x => x % 2 != 0).Sum();
            Console.WriteLine($"Массив: {string.Join(" ", B1)}");
            Console.WriteLine($"Положительных: {countPos1}, Сумма нечетных: {sumOdd1}\n");
        }
    }
}