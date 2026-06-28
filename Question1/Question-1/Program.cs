using System;
class Program
{
    static void Main()
    {
        int a = 10, b = 25, c = 15;

        int largest;

        if (a >= b && a >= c)
        {
            largest = a;
        }
        else if (b >= a && b >= c)
        {
            largest = b;
        }
        else
        {
            largest = c;
        }

        Console.WriteLine("Largest number is: " + largest);
    }
}