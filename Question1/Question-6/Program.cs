using System;
class Program
{
    static void Main()
    {
        static double Average(params double[] numbers)
        {
            double sum = 0;

            foreach (double num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }
        Console.WriteLine("Average of given numbers is " + Average(10.45, 20.46, 24.765, 12.34));
    }
}