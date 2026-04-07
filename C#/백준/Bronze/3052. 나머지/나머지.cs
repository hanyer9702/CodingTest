using System;

class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int>();
        for(int i = 0; i < 10; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num % 42);
        }
        Console.WriteLine(numbers.Count);
    }
}