using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sb = new StringBuilder();
        
        var nm = sr.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);
        
        List<int>[] graph = new List<int>[n + 1];
        int[] indegree = new int[n + 1];
        Array.Fill(indegree, 0);
        for(int i = 1; i <= n; i++)
            graph[i] = new List<int>();
        
        for(int i = 0; i < m; i++)
        {
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int num = arr[0];
            
            for(int j = 2; j <= num; j++)
            {
                graph[arr[j - 1]].Add(arr[j]);
                indegree[arr[j]]++;
            }
        }
        
        Queue<int> q = new Queue<int>();
        for(int i = 1; i <= n; i++)
        {
            if(indegree[i] == 0)
                q.Enqueue(i);
        }
        
        List<int> list = new List<int>();
        while(q.Count > 0)    
        {
            int cur = q.Dequeue();
            list.Add(cur);
            
            foreach(var next in graph[cur])
            {
                indegree[next]--;
                if(indegree[next] == 0)
                    q.Enqueue(next);
            }
        }

        if(list.Count != n)
            sb.AppendLine("0");
        else
        {
            foreach(var num in list)
                sb.AppendLine(num.ToString());
        }
            
        Console.Write(sb.ToString());
    }
}