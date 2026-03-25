using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        
        int n = int.Parse(sr.ReadLine());
        int m = int.Parse(sr.ReadLine());
        
        List<(int to, int cost)>[] graph = new List<(int, int)>[n];
        for(int i = 0; i < n; i++)
            graph[i] = new List<(int, int)>();
        
        for(int i = 0; i < m; i++)
        {
            var inputNode = sr.ReadLine().Split();
            int startNode = int.Parse(inputNode[0]) - 1;
            int stopNode = int.Parse(inputNode[1]) - 1;
            int nodeDist = int.Parse(inputNode[2]);
            
            graph[startNode].Add((stopNode, nodeDist));
        }
        
        var input = sr.ReadLine().Split();
        int start = int.Parse(input[0]) - 1;
        int stop = int.Parse(input[1]) - 1;
        
        var (dist, path) = Dijkstra(graph, n, start, stop);
        Console.WriteLine(dist.ToString());
        Console.WriteLine(path.Count.ToString());
        
        String pathAll = "";
        for(int i = 0; i < path.Count; i++)
        {
            pathAll += path[i] + " ";
        }
        Console.WriteLine(pathAll.TrimEnd());
    }
    
    static (int, List<int>) Dijkstra(List<(int to, int cost)>[] graph, int n, int start, int stop)
    {
        int[] dist = new int[n];
        bool[] visited = new bool[n];
        int[] prev = new int[n];
        List<int> path = new List<int>();
        Array.Fill(dist, int.MaxValue);
        dist[start] = 0;
        
        for(int i = 0; i < n; i++)
        {
            int minDist = int.MaxValue;
            int cur = -1;
            
            for(int j = 0; j < n; j++)
            {
                if(!visited[j] && dist[j] < minDist)
                {
                    minDist = dist[j];
                    cur = j;
                }
            }
            
            if(cur == -1) break;
            visited[cur] = true;
            
            foreach(var next in graph[cur])
            {
                int nextnode = next.to;
                int cost = next.cost;
                
                if(dist[nextnode] > dist[cur] + cost)
                {
                    dist[nextnode] = dist[cur] + cost;
                    prev[nextnode] = cur;
                }
            }
        }
        
        path = getPath(prev, start, stop);
        
        return (dist[stop], path);
    }
    
    static List<int> getPath(int[] prev, int start, int stop)
    {
        List<int> path = new List<int>();
        int cur = stop;
        
        while(cur != start)
        {
            path.Add(cur + 1);
            cur = prev[cur];
        }
        path.Add(start + 1);
        
        path.Reverse();
        
        return path;
    }
}