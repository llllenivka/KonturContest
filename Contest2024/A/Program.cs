public class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
            
        long T = long.Parse(input[1]);
        
        long minCount = Console.ReadLine().Split(" ").Select(long.Parse).ToArray().Sum();
        long maxCount = Console.ReadLine().Split(" ").Select(long.Parse).ToArray().Sum();
        
        if(T < minCount || T > maxCount) Console.Write("NO");
        else Console.Write("YES");
        
         

    }
}


