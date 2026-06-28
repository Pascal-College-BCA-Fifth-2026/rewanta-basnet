using System;

class Program
{
    static void CountGender(char?[] genderCollection)
    {
        int male = 0, female = 0, others = 0;

        foreach (char? gender in genderCollection)
        {
            if (gender == 'M')
            {
                male++;
            }
            else if (gender == 'F')
            {
                female++;
            }
            else
            {
                others++;
            }
        }

        Console.WriteLine("Total Males = " + male);
        Console.WriteLine("Total Females = " + female);
        Console.WriteLine("Total Others = " + others);
    }

    static void Main()
    {
        char?[] genderCollection =
        {
            'F', 'M', 'F', 'M', null,
            'M', null, 'F', 'F', 'M',
            null, null, 'F', 'M', 'M'
        };

        CountGender(genderCollection);
    }
}