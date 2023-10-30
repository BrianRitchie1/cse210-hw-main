using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;



class Listening : Program
{
    public void content()
    {        
        Listening = pro_listenting;
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random random = new Random();
        List<string> listening_prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        int index = random.Next(listening_prompts.Count);
        Console.WriteLine(listening_prompts[index]);

        Console.WriteLine("Begin to think on the prompt");
        Thread.Sleep(1000);
        Console.WriteLine("Ready? ");

        
        Console.Write("(Put your entry here): ");
        string listening_entry = Console.ReadLine();
        

    }
}

