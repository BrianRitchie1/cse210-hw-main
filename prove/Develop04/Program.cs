using System;
using System.Reflection.Metadata;
using System.Threading;

class Program
{
    static void Main()
    {
        
        Random random = new Random();
        Listening Pro_listening = new Listening();
        Breathing breathing = new Breathing();
        Reflection reflecting= new Reflection();
        while (true)
        {
            Console.WriteLine("Choose a fun activity");
            Console.WriteLine("");
            Console.WriteLine("1: Breathing ");
            Console.WriteLine("2: Listening ");
            Console.WriteLine("3: Relflection ");
            Console.WriteLine("4: Quit ");
            int choice = int.Parse(Console.ReadLine());

        
        switch (choice)
        {
            case 1:
                Console.WriteLine("breathing activity");
                break;
            case 2:
                Console.WriteLine ("What is the time would would like to ponder?");
                int utimer = Console.Read();
                utimer = utimer * 1000;
                Console.WriteLine(utimer);
                Pro_listening.content();
                break;
            case 3:
                // Add code for the Reflecting activity
                Console.WriteLine("Reflecting activity");
                break;
            case 4:
                Console.WriteLine("Goodbye!");
                return; // Exit the program
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
}
    }
}