using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    string scripture = "I loved to eat cows";
    
    List<string> result = scripture.Split(',').ToList();

    Console.WriteLine(scripture[1]);
    }
}