using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the decimal numbers:");
        double num1 = Convert.ToDouble( Console.ReadLine());
        double num2 = Convert.ToDouble( Console.ReadLine());
        double num3 = Convert.ToDouble( Console.ReadLine());

        double average = (num1 + num2 + num3) / 3;

        Console.WriteLine("The average of the 3 decimal numbers is: " + average);
    }
}