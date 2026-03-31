using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        
        int n = int.Parse(sr.ReadLine());
        int[,] arr = new int[n,3];
        for(int i = 0; i < n; i++)
        {
            var input = sr.ReadLine().Split();
            arr[i,0] = int.Parse(input[0]);
            arr[i,1] = int.Parse(input[1]);
            arr[i,2] = int.Parse(input[2]);
        }
        
        int[,] dp = new int[n,3];
        dp[0,0] = arr[0,0];
        dp[0,1] = arr[0,1];
        dp[0,2] = arr[0,2];
        for(int i = 1; i < n; i++)
        {
            dp[i, 0] = Math.Min(dp[i - 1, 1], dp[i - 1, 2]) + arr[i, 0];
            dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 2]) + arr[i, 1];
            dp[i, 2] = Math.Min(dp[i - 1, 0], dp[i - 1, 1]) + arr[i, 2];
        }

        int min = Math.Min(dp[n - 1, 0], Math.Min(dp[n - 1, 1], dp[n - 1, 2]));
        Console.WriteLine(min);
    }
}