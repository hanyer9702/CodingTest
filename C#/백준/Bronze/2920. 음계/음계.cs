using System;

class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int pos = arr[0];
        string result = "";
        
        if(pos == 1)
        {
            for(int i = 1; i < 8; i++)
            {
                pos++;
                if(arr[i] != pos)
                {
                    result = "mixed";
                    break;
                }
            }
            if(pos == 8)
                result = "ascending";
        }
        else if(pos == 8)
        {
            for(int i = 1; i < 8; i++)
            {
                pos--;
                if(arr[i] != pos)
                {
                    result = "mixed";
                    break;
                }
            }
            if(pos == 1)
                result = "descending";
        }
        else
            result = "mixed";
        
        Console.WriteLine(result);
    }
}