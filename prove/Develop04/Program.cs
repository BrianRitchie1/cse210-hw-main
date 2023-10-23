using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Loading...");
        Spinner spinner = new Spinner();
        spinner.Start();
        // Simulate some loading work (replace this with your actual loading code)
        Thread.Sleep(5000);
        spinner.Stop();
        Console.WriteLine("Loading complete!");
    }
}

class Spinner
{
    private bool _stop = false;

    public void Start()
    {
        _stop = false;
        Thread thread = new Thread(Spin);
        thread.Start();
    }

    public void Stop()
    {
        _stop = true;
    }

    private void Spin()
    {
        while (!_stop)
        {
            Console.Write("/");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("-");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("\\");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("|");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}
