using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List <int> numbers = new List<int>();
        int BR_List_Input = -1;
        while (BR_List_Input != 0)
        {
            Console.Write("Enter a number (zero to quit)");
            string userResponse = Console.ReadLine();
            BR_List_Input = int.Parse(userResponse);

            if (BR_List_Input != 0)
            {
                numbers.Add(BR_List_Input);
            }
        }

        int BR_sum = 0;
        foreach (int number in numbers)
        {
            BR_sum += number;
        }

        Console.WriteLine($"The sum is: {BR_sum}");


        float BR_Average = ((float)BR_sum) / numbers.Count;

        int BR_max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > BR_max)
            {
                BR_max = number;
            }
        }
        Console.WriteLine($"The big number is {BR_max}");



    }
}