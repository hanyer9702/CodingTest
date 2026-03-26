using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        Array.Sort(arr);
        
        (long n1, long n2) = TPointer(arr);
        Console.WriteLine(n1.ToString() + " " + n2.ToString());
    }
    
    static (long, long) TPointer(long[] arr)
    {
        long left = 0;
        long right = arr.Length - 1;
        long min = arr[0];
        long max = arr[right];
        
        if(min + max == 0)
            return (min, max);
        
        while(left < right)
        {
            if(Math.Abs(min + max) > Math.Abs(arr[left] + arr[right]))
            {
                min = arr[left];
                max = arr[right];
            }
            
            if(min + max == 0)
                break;
            
            if(arr[left] + arr[right] < 0)
                left++;
            else if(arr[left] + arr[right] > 0)
                right--;
        }
        
        return (min, max);
    }
}