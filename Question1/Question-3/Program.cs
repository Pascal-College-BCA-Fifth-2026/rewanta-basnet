//program to find out the entered number is even or not using ternary operator
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        string result = (num%2 == 0) ? "Even" : "Odd";
        Console.WriteLine("The number " + num + " is " + result);
    }
}