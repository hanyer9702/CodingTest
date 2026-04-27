using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] dp = new int[n];
        
        dp[0] = 1;
        for(int i = 1; i < n; i++)
        {
            int num = 0;
            for(int j = 0; j < i; j++)
            {
                if(a[j] < a[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);  
                    num = dp[i];
                }
            }
            if(num == 0)
                dp[i] = 1;
            
            num = 0;
        }
        
        Console.WriteLine(dp.Max());
    }
}