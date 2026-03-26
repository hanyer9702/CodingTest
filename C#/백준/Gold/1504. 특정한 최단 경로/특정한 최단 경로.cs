using System;
using System.IO;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        
        var ne = sr.ReadLine().Split();
        int n = int.Parse(ne[0]);
        int e = int.Parse(ne[1]);
        
        List<(int, int)>[] graph = new List<(int, int)>[n];
        for(int i = 0; i < n; i++)
            graph[i] = new List<(int, int)>();
        
        for(int i = 0; i < e; i++)
        {
            var abc = sr.ReadLine().Split();
            int a = int.Parse(abc[0]) - 1;
            int b = int.Parse(abc[1]) - 1;
            int c = int.Parse(abc[2]);
            
            graph[a].Add((b, c));
            graph[b].Add((a, c));
        }
        
        var v = sr.ReadLine().Split();
        int v1 = int.Parse(v[0]) - 1;
        int v2 = int.Parse(v[1]) - 1;

        int INF = int.MaxValue;
        int path1 = 0;
        int path2 = 0;
        int result1 = Dijkstra(graph, n, 0, v1);
        int result2 = Dijkstra(graph, n, v1, v2);
        int result3 = Dijkstra(graph, n, v2, n - 1);

        int result4 = Dijkstra(graph, n, 0, v2);
        int result5 = Dijkstra(graph, n, v2, v1);
        int result6 = Dijkstra(graph, n, v1, n - 1);

        if(result1 == INF || result2 == INF || result3 == INF)
            path1 = INF;
        else
            path1 = result1 + result2 + result3;

        if(result4 == INF || result5 == INF || result6 == INF)
            path2 = INF;
        else
            path2 = result4 + result5 + result6;

        if(path1 == INF && path2 == INF)
            Console.WriteLine("-1");    
        else
            Console.WriteLine(path1 < path2 ? path1 : path2);
    }
    
    static int Dijkstra(List<(int to, int cost)>[] graph, int n, int start, int stop)
    {
        int[] dist = new int[n];
        bool[] visited = new bool[n];
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
                    dist[nextnode] = dist[cur] + cost;
            }
        }

        return dist[stop];
    }
}