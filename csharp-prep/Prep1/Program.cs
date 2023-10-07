using System;

namespace gamer

{
    class Program 
    {

    
        static void Main(string[] args)
        {
            Console.WriteLine("What's good? ");
            Console.Write("What is your first name? ");
            string BR_f_name = Console.ReadLine();
            Console.Write("What is your last name? ");
            string BR_l_name = Console.ReadLine();
            Console.WriteLine($"Your name is {BR_l_name}, {BR_f_name} {BR_l_name}");
        }
    }
}