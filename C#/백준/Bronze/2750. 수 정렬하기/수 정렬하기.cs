using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        
        for(int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        
        list.Sort();
        
        foreach(var num in list)
        {
            Console.WriteLine(num);
        }
    }
}