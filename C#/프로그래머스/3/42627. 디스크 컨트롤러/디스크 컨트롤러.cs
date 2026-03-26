using System;
using System.Collections.Generic;

public class Solution {
    List<int[]> heap = new List<int[]>();
    public int solution(int[,] jobs) {
        int n = jobs.GetLength(0);
        
        // 요청시간 기준 정렬
        int[][] arr = new int[n][];
        for(int i = 0; i < n; i++)
            arr[i] = new int[] { jobs[i,0], jobs[i,1] };
        
        Array.Sort(arr, delegate(int[] a, int[] b)
        {
            return a[0].CompareTo(b[0]);
        });
        
        int time = 0;
        int total = 0;
        int idx = 0;
        
        while(idx < n || heap.Count > 0)
        {
            while(idx < n && arr[idx][0] <= time)
            {
                Push(arr[idx][1], arr[idx][0]);
                idx++;
            }

            if(heap.Count > 0)
            {
                int[] job = Pop();
                time += job[0];
                total += time - job[1];
            }
            else
            {
                time = arr[idx][0];
            }
        }
        
        return total / n;
    }
    
    public void Push(int l, int s)
    {
        heap.Add(new int[] {l, s});
        int i = heap.Count - 1;
        
        while(i > 0)
        {
            int parent = (i - 1) / 2;
            
            if(heap[parent][0] <= heap[i][0]) break;
            
            var tmp = heap[parent];
            heap[parent] = heap[i];
            heap[i] = tmp;
            
            i = parent;
        }
    }
    
    public int[] Pop()
    {
        int last = heap.Count - 1;
        int[] ret = heap[0];
        heap[0] = heap[last];
        heap.RemoveAt(last);
        int i = 0;
        
        while(true)
        {
            int left = i * 2 + 1;
            int right = i * 2 + 2;
            int smallest = i;
            
            if(left < heap.Count && heap[left][0] < heap[smallest][0])
                smallest = left;
            if(right < heap.Count && heap[right][0] < heap[smallest][0])
                smallest = right;
            if(smallest == i) break;
            
            var tmp = heap[smallest];
            heap[smallest] = heap[i];
            heap[i] = tmp;
            
            i = smallest;
        }
        
        return ret;
    }
}