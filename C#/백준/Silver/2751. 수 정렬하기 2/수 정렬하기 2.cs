using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        for(int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        Array.Sort(arr);
        
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < n; i++)
        {
            sb.AppendLine(arr[i].ToString());
        }
        
        Console.WriteLine(sb.ToString());
    }
}