using System;
using System.IO;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        int n = int.Parse(sr.ReadLine());
        int[,] arr = new int[n, n];
        for(int i = 0; i < n; i++)
        {
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            for(int j = 0; j < input.Length; j++)
            {
                arr[i, j] = input[j];
            }
        }
        
        int[,] result = new int[n, n];
        result[0, 0] = arr[0, 0];
        for(int i = 1; i < n; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                if(j == 0)
                    result[i, j] = result[i - 1, j] + arr[i, j];
                else
                    result[i, j] = Math.Max(result[i - 1, j - 1], result[i - 1, j]) + arr[i, j];
            }
        }
        
        int max = 0;
        for(int i = 0; i < n; i++)
        {
            if(result[n - 1, i] > max)
                max = result[n - 1, i];
        }
        Console.WriteLine(max);
    }
}