using System;
using System.IO;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        
        var nk = sr.ReadLine().Split();
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);
        
        List<(int m, int v)> jewel = new List<(int, int)>();
        for(int i = 0; i < n; i++)
        {
            var mv = sr.ReadLine().Split();
            int m = int.Parse(mv[0]);
            int v = int.Parse(mv[1]);
            jewel.Add((m, v));
        }
        
        long[] bag = new long[k];
        for(int i = 0; i < k; i++)
            bag[i] = long.Parse(sr.ReadLine());
        
        jewel.Sort((a, b) => a.m.CompareTo(b.m));
        Array.Sort(bag);
        
        List<int> maxHeap = new List<int>();

        long result = 0;
        int idx = 0;
        
        foreach(var w in bag)
        {
            while(idx < n && jewel[idx].m <= w)
            {
                Push(maxHeap, jewel[idx].v);
                idx++;
            }
            
            if(maxHeap.Count > 0)
                result += Pop(maxHeap);
        }
        
        Console.WriteLine(result.ToString());
    }
    
    static void Push(List<int> heap, int val)
    {
        heap.Add(val);
        int i = heap.Count - 1;
        
        while(i > 0)
        {
            int parent = (i - 1) / 2;
            
            if(heap[parent] >= heap[i])
                break;
            
            (heap[parent], heap[i]) = (heap[i], heap[parent]);
            i = parent;
        }
    }
    
    static int Pop(List<int> heap)
    {
        int last = heap.Count - 1;
        int rt = heap[0];
        heap[0] = heap[last];
        heap.RemoveAt(last);
        int i = 0;
        
        while(true)
        {
            int left = i * 2 + 1;
            int right = i * 2 + 2;
            int largest = i;
            
            if(left < heap.Count && heap[left] > heap[largest])
                largest = left;
            if(right < heap.Count && heap[right] > heap[largest])
                largest = right;
            if(largest == i) break;
            
            (heap[largest], heap[i]) = (heap[i], heap[largest]);
            i = largest;
        }

        return rt;
    }
}