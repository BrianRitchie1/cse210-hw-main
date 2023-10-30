using System;
using System.Reflection.Metadata;
using System.Threading;

class Program
{
    static void Main()
    {
        string _pro_listening;
        
        Random random = new Random();
        Listening Pro_listening = new Listening();

        while (true)
        {
            Console.WriteLine("Choose a fun activity");
            Console.WriteLine("");
            Console.WriteLine("1: Breathing ");
            Console.WriteLine("2: Listening ");
            Console.WriteLine("3: Relflection ");
            
            int choice = int.Parse(Console.ReadLine());

        
        switch (choice)
        {
            case 1:
                Console.WriteLine ("What is the time would would like to ponder?");
                int utimer = Console.Read();
                utimer = utimer * 1000;
                Console.WriteLine(utimer);
                Pro_listening.content();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;


        }

        }
    }
}