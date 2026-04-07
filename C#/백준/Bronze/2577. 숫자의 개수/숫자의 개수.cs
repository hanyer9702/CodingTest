using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string mul = (a * b * c) + "";
        int[] arr = new int[10];
        Array.Fill(arr, 0);
        for(int i = 0; i < mul.Length; i++)
        {
            int n = int.Parse(mul[i].ToString());
            arr[n]++;
        }
        
        foreach(var num in arr)
            Console.WriteLine(num);
    }
}