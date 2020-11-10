//Counting the amount of numbers introduced which have one, two, three or more digits

using System;

class digits
{
    static void Main()
    {
        int counterOneDigit = 0, counterTwoDigits = 0, counterThreeDigits = 0,
        counterMoreThanThreeDigits = 0;

        Console.Write("Insert a number: ");
        string inputString = Console.ReadLine();

        while (inputString != "end")
        {
            int input = Convert.ToInt32(inputString);
            if (input != 0)
            {
                if (input / 10 == 0)
                {
                    counterOneDigit++;
                }
                else
                {
                    if (input / 100 == 0)
                    {
                        counterTwoDigits++;
                    }
                    else
                    {
                        if (input / 1000 == 0)
                        {
                            counterThreeDigits++;
                        }
                        else
                        {
                            counterMoreThanThreeDigits++;
                        }
                    }
                }
            }
            inputString = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", counterOneDigit,
        counterTwoDigits, counterThreeDigits, counterMoreThanThreeDigits);
    }
}

