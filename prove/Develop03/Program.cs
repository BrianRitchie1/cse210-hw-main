using System;
using System.Collections.Generic;
using System.Linq;

public class BTR_WORD
{
    public string scripture {get; private set;}

    public bool Is_Dead {get; private set;}

    public BTR_WORD (string scripture1)
    {
        scripture = scripture1;
        Is_Dead = false;
    }

    public void Kill()
    {
        Is_Dead = true;
    }

    public override string ToString()
    {
        return Is_Dead ? "_____" : scripture;
    } 

}
public class SCR_REF
{
    public string Reference {get; private set;}
    public SCR_REF(string reference)
    {
        Reference = reference;
    }

    public override string ToString()
    {
        return Reference;
    }


}
public class Scripture_CNT
{
    public SCR_REF Reference {get; private set;}

    public List<BTR_WORD> Content {get; private set;}

    public Scripture_CNT (SCR_REF reference, string scripture)
    {
        Reference = reference;
        Content = scripture.Split(' ').Select(word => new BTR_WORD(word)).ToList();
    }

    public void Firing_Squad()
    {
        Random random = new Random();
        List<BTR_WORD> visibleContent = Content.Where(word => !word.Is_Dead).ToList();
        int index = random.Next(visibleContent.Count);
        visibleContent[index].Kill();
    }   

    public bool NoLivingLeft()
    {
        return Content.All(word => word.Is_Dead);
    }

    public override string ToString()
    {
        return $"{Reference}\n\n{string.Join(" ", Content)}";
    }

}

public class Program1
{
    public static void Main()
    {
        Console.Write("What is the name of the scripture? ");
        string referenceInput = Console.ReadLine();
        SCR_REF reference = new SCR_REF(referenceInput);

        Console.Write("Enter scripture text: ");
        string context = Console.ReadLine();
        Scripture_CNT scripture = new Scripture_CNT(reference, context);

        while (!scripture.NoLivingLeft())
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.Firing_Squad();
        }

    }


}