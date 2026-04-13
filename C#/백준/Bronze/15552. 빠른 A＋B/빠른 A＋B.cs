using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sb = new StringBuilder();
        
        int t = int.Parse(sr.ReadLine());
        for(int i = 0; i < t; i++)
        {
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int num = arr[0] + arr[1];
            sb.AppendLine(num.ToString());
        }
        Console.Write(sb.ToString());
    }
}