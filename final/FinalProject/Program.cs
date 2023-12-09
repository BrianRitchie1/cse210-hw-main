using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Gets the master budget
        List<Tissue> Budgets = new List<Tissue>();
        Console.Write("What is you master budget? (The most amount of money you are willing to distribute for budgeting) ");
        int BtrvalueMaster = int.Parse(Console.ReadLine());



        while (true)
        {
            //Options menu that allows user to exit
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Budget");
            Console.WriteLine("2. Display your budgets");
            Console.WriteLine("3. Save all budgets ");
            Console.WriteLine("4. Load budgets ");
            Console.WriteLine("5. Record Time Budget Completion Status ");
            Console.WriteLine("6. Quit");
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {

                case "1":
                    CreateBudget(Budgets, ref BtrvalueMaster);
                    break;
                case "2":
                    DisplayBudget(Budgets, BtrvalueMaster);
                    break;
                case "3":
                    SaveBudget("budget.txt", Budgets);
                    Console.WriteLine("Budget(s) saved.");
                    break;
                case "4":
                    Budgets = LoadBudgets("budgets.txt");
                    Console.WriteLine("Budgets loaded.");
                    break;
                case "5":
                    RecordEvent(Budgets, BtrvalueMaster);
                    break;
                case "6":
                    SaveBudget("budgets.txt", Budgets);
                    Console.WriteLine("Budgets saved. Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void CreateBudget(List<Tissue> Budgets, ref int BtrvalueMaster)
    {
        //Menu for Budgets
        Console.WriteLine("\nChoose Budget Type:(Round up to the nearest dollar)");
        Console.WriteLine("1. A Simple budget ");
        Console.WriteLine("2. A Tithing Budget ");
        Console.WriteLine("3. A Fun Budget ");
        Console.WriteLine("4. A Rent Budget ");
        Console.WriteLine("5. A Time Budget ");
        Console.WriteLine("6. A Food Budget ");

        Console.Write("Enter your choice: ");
        string TypeBuget = Console.ReadLine();

        switch (TypeBuget)
        {
            case "1":
                Budgets.Add(CreateSimpleBudget(BtrvalueMaster));
                break;
            case "2":
                Budgets.Add(CreateThithingBudget());
                break;
            case "3":
                Budgets.Add(CreateFunBudget());
                break;
            case "4": 
                Budgets.Add(CreateRentBudget(BtrvalueMaster));
                break;
            case "5":
                Budgets.Add(CreateTimeBudget());
                break;
            case "6":
                Budgets.Add(CreateFoodBudget());
                break;
            default:
                Console.WriteLine("Invalid choice. Creating a Simple Budget instead");
                Budgets.Add(CreateSimpleBudget(BtrvalueMaster));
                break;
        }
    }

// Creates any budget without help from program
    static Dates CreateSimpleBudget(int BtrvalueMaster)
    {
        Console.Write("Enter the name of the budget: ");
        string titleBtr = Console.ReadLine();
        Console.Write("Enter the initial value of the budget: ");
        int valuesBtr = int.Parse(Console.ReadLine());

        return new Dates(titleBtr, valuesBtr);
    }
    // takes increase / 10
    static Tithing CreateThithingBudget()
    {
        string titleBtr = "Thithing Budget ";
        Console.Write("What did you make this month? ");
        int moneyMade = int.Parse(Console.ReadLine());
        Console.WriteLine($"You should give {moneyMade/10} to the Lord ");
        int valuesBtr = moneyMade/10;

        return new Tithing (titleBtr, valuesBtr);
    }
    // Makes user input an activity that will be displayed with the budget
    static Fun CreateFunBudget()
    {
        Console.Write("This budget is for non essential activites that you enjoy doing. What's a good name for this budget? ");
        string titleBtr = Console.ReadLine();
        Console.Write("What fun activitiy will you be doing? ");
        string fun_description = Console.ReadLine();
        Console.Write("What is the amount you're going to spend? ");
        int valuesBtr = int.Parse(Console.ReadLine());

        return new Fun (titleBtr, valuesBtr, fun_description);
    }

// Creates rent budget that takes into account if you need to move with a simple if statement
    static Rent CreateRentBudget(int BtrvalueMaster)
    {
        Console.Write("This budget is for rent, Duh. What's a good name for this budget? ");
        string titleBtr = Console.ReadLine();
        Console.Write("How much will rent be? ");
        int RentCost = int.Parse(Console.ReadLine());
        int valuesBtr = RentCost;

        if (valuesBtr >= BtrvalueMaster + 100)
        {
            Console.Write("You will need to make more money or find a smaller accomadation. Get on that.");
        }
        else
        {
            Console.WriteLine("Your budget should be suffectint to continure living where you live");
        }


        return new Rent (titleBtr, valuesBtr);
    }
// Creates a time budget that can be checked off in the first menu
    static Timea CreateTimeBudget()
    {
        Console.Write("This is a budget for time. What would you like to call this particular budget? ");
        string titleBtr = Console.ReadLine();
        Console.Write("How many hours do you want to spend on this or that? ");
        int valuesTime = int.Parse(Console.ReadLine());

        return new Timea (titleBtr, valuesTime);
    }

// Creates a food budget with different inputs for different nutrition values
    static Food CreateFoodBudget()
    {
        Console.Write("This is a budget for food. What would you like to call this budget? ");
        string titleBtr = Console.ReadLine();
        Console.WriteLine("A good, REALISTIC, diet consists of a good amount of food with fiber, protien, and a small amount of sweets");

        Console.Write("What food would you like to be your fiber? ");
        string fiberBtr = Console.ReadLine();

        Console.Write("What food would you like to be your protien? ");
        string protienBtr = Console.ReadLine();

        Console.Write("What would you like to be you sweet snack? ");
        string sweetBtr = Console.ReadLine();

        Console.Write("How much would you like to spend on food for this week? ");
        int valuesBtr = int.Parse(Console.ReadLine());


        return new Food (titleBtr, fiberBtr, protienBtr, sweetBtr, valuesBtr);


    }




    
// Allows user to check off time event
    static void RecordEvent(List<Tissue> Budgets, int BtrvalueMaster)
    {
        DisplayBudget(Budgets, BtrvalueMaster);

        Console.Write("\nEnter the index of the budget to record an event: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < Budgets.Count)
        {
            Budgets[index].BtrRecord();
            Console.WriteLine("Event recorded. Points added.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

// Allows user to display all the budgets and their variables. 
    static void DisplayBudget(List<Tissue> Budgets, int BtrvalueMaster)
    {
        Console.WriteLine("\nBudgets:");
        for (int i = 0; i < Budgets.Count; i++)
        {
            Budgets[i].BtrDisplay();
        }
        Console.WriteLine($"\nMaster Budget: {BtrvalueMaster}");
        Console.WriteLine($"\nRemaining Master Budget: {BtrvalueMaster - Budgets.Sum(g => g.BtrPoints)}\n");
    }

// Allows to save to a txt csv file
    static void SaveBudget(string fileName, List<Tissue> Budgets)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var i in Budgets)
            {
                writer.WriteLine(i.BtrToString());
            }
        }
    }
// Loads from save
    static List<Tissue> LoadBudgets(string fileName)
    {
        List<Tissue> BudgetsLoaded = new List<Tissue>();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    Tissue budget = CreateBudgetInstance(parts[0]);
                    budget.BtrFromString(line);
                    BudgetsLoaded.Add(budget);
                }
            }
        }

        return BudgetsLoaded;
    }
// Creates instances
    static Tissue CreateBudgetInstance(string TypeBuget)
    {
        switch (TypeBuget)
        {
            case nameof(Dates):
                return new Dates("", 0);
            default:
                throw new ArgumentException("Invalid ");
        }
    }
}
