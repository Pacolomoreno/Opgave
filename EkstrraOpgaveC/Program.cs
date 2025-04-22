using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Net.Mail;

namespace EkstraOpgaveC;

class Program
{
    static int Sum(int sum1, int sum2)     // Oppgave 1a
    {
        return sum1 + sum2;
    }

    static int SumArray(int[] argument)   // Oppgave 2a
    {
        int result = 0;
        for (int i = 0; i < argument.Length; i++)
        {
            result = result + argument[i];
        }

        return result;
    }
    static void Main(string[] args)
    {
        // Oppgave 1b
        int a = 34;
        int b = 22;
        Console.WriteLine("Result " + Sum(a, b));

        // Oppgave 2b
        int[] arr = [12, 22, 13, 33, 14, 44, 15, 55];
        int sum = SumArray(arr);
        Console.WriteLine("Total sum blir " + sum);

        // Oppgave 3
        Dictionary<string, int> myDictionary = new Dictionary<string, int>()
        {
        {"key", 1},
        {"key1", 2}
        };

        myDictionary.Add("Paco", 50);
        myDictionary.Add("Helez", 30);
        myDictionary.Add("Paul", 43);

        foreach (var item in myDictionary)
        {
            Console.WriteLine("Her er " + item.Key + " som er " + item.Value);
        }

    }


}
