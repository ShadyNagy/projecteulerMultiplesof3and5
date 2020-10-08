using System;

namespace ProjectEulerMultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter below number?");
            var number = int.Parse(Console.ReadLine() ?? string.Empty);

            var result = CalcSumForNumber(3, number) + CalcSumForNumber(5, number) - CalcSumForNumber(15, number);
            var result2 = ComplexCalcSumForNumber(3, number) + ComplexCalcSumForNumber(5, number) - ComplexCalcSumForNumber(15, number);

            Console.WriteLine($"Result is: {result}");
            Console.WriteLine($"Result2 is: {result2}");

            Console.ReadKey();
        }

        static int CalcSumForNumber(int factorNumber, int belowNumber)
        {
            // Get sum numbers can divided by 3 and Below 20
            // Numbers     ->     18+ 15 + 12 + 9 + 6 + 3 = 63
            // how many 3  ->     6 + 5  + 4  + 3 + 2 + 1 = 21 = ((6+1)*(6))/2
            // Sum of all 3->     21 * 3 = 63

            //Get 18
            var countOfNumberCanDivided = (belowNumber - 1) / factorNumber;

            //Get 21
            var factorNumbersSum = (countOfNumberCanDivided * (countOfNumberCanDivided + 1)) / 2;

            // Sum of all 3
            return factorNumbersSum * factorNumber;
        }

        static int ComplexCalcSumForNumber(int factorNumber, int belowNumber)
        {
            var maxNumber = belowNumber - 1;
            var sum = (maxNumber / factorNumber) * ((maxNumber + factorNumber) / factorNumber) * factorNumber / 2;

            return sum;
        }
    }
}
