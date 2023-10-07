using System;

namespace game

{
    class Program 
    {

    
        static void Main(string[] args)
        { 
            Console.Write("What is you score? ");
            string BR_score = Console.ReadLine();

            int BR_C_score = int.Parse(BR_score);

            if (BR_C_score >= 90)
            {
            Console.WriteLine("You got an A ");
            }

            else if (BR_C_score >= 80)
            {
            Console.WriteLine("You got an B ");
            }
            else if (BR_C_score >= 70)
            {
            Console.WriteLine("You got an C ");
            }
            else if (BR_C_score >= 60)
            {
            Console.WriteLine("You got an D ");
            }
            else
            {
            Console.WriteLine("You got an F ");
            }
            


            

        
        

        }
    }
}
