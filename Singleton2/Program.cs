using System;
using System.Collections.Generic;

public sealed class PrintBufor
{
    private static readonly PrintBufor instance = new PrintBufor();
    private List<string> printJobs;

    static PrintBufor()
    {
    }

    private PrintBufor()
    {
        printJobs = new List<string>();
    }

    public static PrintBufor Instance
    {
        get
        {
            return instance;
        }
    }

    public void AddJob(string job)
    {
        printJobs.Add(job);
    }

    public void Print()
    {
        foreach (string job in printJobs)
        {
            Console.WriteLine("Printing: " + job);
        }
        printJobs.Clear();
    }
}

class Program
{
    static void Main(string[] args)
    {
        PrintBufor.Instance.AddJob("dokument 1");
        PrintBufor.Instance.AddJob("dokument 2");
        PrintBufor.Instance.AddJob("dokument 3");

        PrintBufor.Instance.Print();

        Console.ReadKey();
    }
}
