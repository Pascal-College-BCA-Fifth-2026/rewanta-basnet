using System;
class Program
{
    // program to find the sum of square of first n natural numbers

    static void Main()
    {
        int n, sum = 0;
        Console.WriteLine("Enter a number:");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i=1; i<=n; i++)
        {
            sum += i*i;
        }
        Console.WriteLine("The sum of square of first " + n + " natural numbers is: " + sum);
    }
}