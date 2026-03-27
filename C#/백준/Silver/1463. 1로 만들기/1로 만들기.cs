using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int[] dp = new int[x + 1];
        dp[1] = 0;
        
        for(int i = 2; i <= x; i++)
        {
            dp[i] = dp[i - 1] + 1;
            
            if(i % 2 == 0) dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
            if(i % 3 == 0) dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
        }
        
        Console.WriteLine(dp[x].ToString());
    }
}