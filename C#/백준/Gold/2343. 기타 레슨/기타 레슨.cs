using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = nm[0];
        int m = nm[1];
        
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int result = BinarySearch(arr, n, m);
        Console.WriteLine(result);
    }
    
    static int BinarySearch(int[] arr, int n, int m)
    {
        int left = arr.Max();
        int right = arr.Sum();
        int result = 0;
        
        while(left <= right)
        {
            int mid = (left + right) / 2;
            long sum = 0;
            int cnt = 1;
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
                if(sum > mid)
                {
                    sum = arr[i];
                    cnt++;
                }
            }
            
            if(cnt <= m)
            {
                result = mid;
                right = mid - 1;
            }
            else
                left = mid + 1;
        }
        return result;
    }
}