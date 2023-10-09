
/* 

Name: Digital Journal
Purpose: Records prompts from user
Author(s): Gilber Chen, Ty Saltzgiver, Brian Ritchie, Bradley Roberts
Date: (c) 2023

*/
using System;

class Program
{
    static void Main(string[] args)
    {
        tsJournal tsSaveJournal = new tsJournal();
        Random random = new Random();
        List<string> tsPrompts = new List<string>()
        {
            "Gratitude: Write down three things you're grateful for today.",
            "Daily Affirmation: What positive affirmation will you carry with you today?",
            "Goals: List three short-term goals you want to accomplish this week.",
            "Mindfulness: Reflect on a moment from today that you want to remember.",
            "Self-Care: How did you practice self-care today? If not, how can you tomorrow?",
            "Challenges: What obstacles did you face today, and how did you overcome them?",
            "Happiness Jar: Write a note about something that made you happy today and put it in a jar.",
            "Random Act of Kindness: Describe an act of kindness you performed or witnessed today.",
            "Emotions Check-In: How are you feeling today, and why do you think you feel this way?",
            "Bucket List Item: Write about one thing you'd like to do before the year ends.",
            "Learning Experience: What did you learn today, and how can you apply it in the future?",
            "Book/Movie Reflection: Share your thoughts on a book or movie you experienced today.",
            "Letter to Your Future Self: Write a message to yourself that you'll read later in the year.",
            "Nature's Beauty: Describe something beautiful in nature that caught your attention today.",
            "Creativity Corner: Sketch, doodle, or write something creative and free-flowing.",
            "Forgiveness: Is there something or someone you need to forgive today?",
            "Mindset Shift: Reflect on a belief or perspective that has changed recently.",
            "Savoring the Moment: Write about an experience you fully embraced today.",
            "Gratitude for Growth: How have you grown or changed in the past year, and what contributed to it?",
            "Favorite Quote: Share a quote that resonates with you and explain why.",
            "Rick Roll: Never gonna give you up, never gonna let you down."
        };
 while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());
 switch (choice)
            {
                case 1:
                    int index = random.Next(tsPrompts.Count);
                    Console.WriteLine(tsPrompts[index]);
                    string tsResponse = Console.ReadLine();
                    tsSaveJournal.AddEntry(new tsJournalEntry(tsPrompts[index], tsResponse));
                    break;
                case 2:
                    tsSaveJournal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Please enter a filename: ");
                    string tsSaveFilename = Console.ReadLine();
                    tsSaveJournal.tsSaveToFile(tsSaveFilename);
                    break;
                     case 4:
                    Console.Write("Please enter a filename: ");
                    string tsLoadFilename = Console.ReadLine();
                    tsSaveJournal.tsLoadFromFile(tsLoadFilename);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}