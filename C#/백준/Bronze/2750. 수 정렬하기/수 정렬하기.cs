using System;
using System.IO;

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
        
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - i - 1 ; j++)
            {
                if(list[j] > list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
        
        foreach(var num in list)
        {
            Console.WriteLine(num);
        }
    }
}