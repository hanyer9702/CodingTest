using System;
using System.Text;

class Program
{
    static void Main()
    {
        var sb = new StringBuilder();
        int n = int.Parse(Console.ReadLine());
        
        for(int i = n; i > 0; i--)
            sb.AppendLine(i.ToString());
        
        Console.Write(sb.ToString());
    }
}