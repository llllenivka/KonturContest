using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int maxCount = 0;
        string bestString = "";

        for (int i = 0; i < N; i++)
        {
            string current = Console.ReadLine();
            int uniqueCount = new HashSet<char>(current).Count;
            
            if (uniqueCount > maxCount)
            {
                maxCount = uniqueCount;
                bestString = current;
            }
        }
        
        Console.WriteLine($"{maxCount} {bestString}");
    }
}