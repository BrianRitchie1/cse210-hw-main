using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenorator = new Random();
        int BR_Correct_Number = randomGenorator.Next(1,11);
        int BR_User_input = -1;

        while (BR_User_input != BR_Correct_Number)
        {
            Console.Write("Pick a number");
            BR_User_input = int.Parse(Console.ReadLine());
            
            if (BR_Correct_Number > BR_User_input)
            {
                Console.WriteLine("The number you are looking for is higher");
            }
            else if (BR_Correct_Number > BR_User_input)
            {
                Console.WriteLine("The number you are looking for is lower");
            }
            else 
            {
                Console.WriteLine("Good job my guy");

            }



        }



    }
}