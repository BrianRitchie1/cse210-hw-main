using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        List <Tissue> Budget_Menu = new List<Tissue>();
        int Console.WriteLine("What is your budget? ");
        int UltimateBudget = Console.ReadLine();

        while (True);
        {
            Console.WriteLine("/nMenu:");
            Console.WriteLine("1. Display Budgets ");
            Console.WriteLine("2. Create Budget ");            Console.Writeline("8. Save Budgets ")
            Console.WriteLine("3. Save Your Budget ");
            Console.Writeline("4. Load Ya stuff ");
            Console.WriteLine("5. Finantial Advice ");
            Console.WriteLine("6. Quit ");
            Console.Write("/nEnter your choice: ");
            string choice = Console.Readline();

            switch (choice)
            {
                case "1":
                    DisplayBudgets(Budget_Menu);
                    break;
                case "2":
                    Create_Budget(Budget_Menu);
                    break;
                case "3":
                    Save_budgets(Budget_Menu);
                    break;
                case "4":
                    L_B = Load_Budgets(Budget_Menu);
                    break;
                case "5":
                    Finantial_Advice;
                case "6":
                    Console.WriteLine("Bye Bye");
                    return;
                default:
                    Console.WriteLine("Wrong ");
                    break;

                    
            }
        }
    }
}

static void Create_Budget(List<Tissue> )
{
    Console.WriteLine("What type of budget are you trying to make? ");
    Console.WriteLine("1. Tithing ");
    Console.WriteLine("2. Rent ");
    Console.WriteLine("3. Food ");
    Console.WriteLine("4. Dating ");
    Console.WriteLine("5. Fun");
    Console.Write(" - ");
    string Budget_Flavor = Console.Readline();

    switch (Budget_Flavor)
    {
        case "1":
            Budget_Menu.Add(CreateTithingBudget);
            break;
        case "2":
            Budget_Menu.Add(CreateRentBudget);
            break;
        case "3":
            Budget_Menu.Add(CreateFoodBudget);
            break;
        case "4":
            Budget_Menu.Add(CreateDatingBudget);
            break;
        case "5";
            Budget_Menu.Add(CreateFunBudget);
            break;
        default:
            Console.Writeline("You suck ")
            break;
    }


    static Tithing CreateTithingBudget()
    {
        Console.Writeline("How much money have you made sine your last donation? ");
        int fakeTithingAmount = Console.ReadLine();
        realTithingAmount = fakeTithingAmount / 10;
        Console.WriteLine($"You should be paying {realTithingAmount}");
    }

    static Rent CreateRentBudget();
    {

    }




}