using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        BR_DisplayWelcomeMessage();

        string userName = BR_PromptUserName();

        int userNumber = BR_PromptUserNumber();

        int squaredNumber = BR_SquaredNumber(userNumber);

        BR_DisplayResult(userName, squaredNumber);

    }
    static void BR_DisplayWelcomeMessage()
    {
        Console.WriteLine("Wazzup!");
    }
    static string BR_PromptUserName()
    {
        Console.Write("Give me yo name ");
        string name = Console.ReadLine();

        return name;
    }
    static int BR_PromptUserNumber()
    {
        Console.Write("Give me yo favorite number ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int BR_SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void BR_DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of yo number is {square}");
    }
}