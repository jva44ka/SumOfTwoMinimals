using System;
using System.Linq;

namespace SumOfTwoMinimals.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленные элементы массива через пробел");
            var input = Console.ReadLine();
            var intArray = input
                .Split(' ')
                .Select(numberAsChar => int.Parse(numberAsChar))
                .ToArray();

            var sumResult = new SumFinder().GetSumOfTwoMinimals(intArray);
            Console.WriteLine("Сумма двух наименьших элементов: {0}", sumResult);
        }
    }
}
