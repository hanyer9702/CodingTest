using System;
using System.Text;

class Program
{
    static void Main()
    {
        var sb = new StringBuilder();
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            sb.AppendLine(i.ToString());
        }
        Console.Write(sb.ToString());
    }
}