using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the alphabet:");
        char ch = Convert.ToChar(Console.ReadLine());

        string vowels = "AEIOUaeiou";

        if (vowels.Contains(ch))
        {
            Console.WriteLine(ch + "is a vowel.");
        }
        else
        {
            Console.WriteLine(ch + "is not a vowel.");
        }
    }
}