using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int min = arr[0];
        int max = arr[0];
        
        for(int i = 1; i < n; i++)
        {
            if(arr[i] < min) min = arr[i];
            if(arr[i] > max) max = arr[i];
        }
        
        Console.WriteLine(min + " " + max);
    }
}