using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> list = new List<int>();
        if(arr.Length == 1)
            list.Add(-1);
        else
        {
            int min = arr[0];
            foreach(var num in arr)
            {
                list.Add(num);
                if(num < min)
                    min = num;
            }
            list.Remove(min);
        }
        
        return list.ToArray();
    }
}