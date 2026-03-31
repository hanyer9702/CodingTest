using System;

public class Solution {
    public int solution(int[] d, int budget) {
        Array.Sort(d);
        int sum = 0;
        int count = 0;
        for(int i = 0; i < d.Length; i++)
        {
            if(sum + d[i] > budget)
                break;
            
            sum += d[i];
            count++;
        }
        
        return count;
    }
}
