using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerMultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter below number?");
            var number = int.Parse(Console.ReadLine() ?? string.Empty);
            var result = CalcSumForNumber(3, number) + CalcSumForNumber(5, number) - CalcSumForNumber(15, number);

            Console.WriteLine($"Result is: {result}");

            Console.ReadKey();
        }

        static int CalcSumForNumber(int mainNumber, int inNumber)
        {
            var howManyMainNumberInLast = (inNumber - 1) / mainNumber;
            var howManyMainNumberInNumber = howManyMainNumberInLast * (howManyMainNumberInLast + 1) / 2;

            return howManyMainNumberInNumber * mainNumber;
        }
    }
}
