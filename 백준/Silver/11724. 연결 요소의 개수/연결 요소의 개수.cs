using System;

public class Program
{
    public static void Main(string[] args)
    {
        Program p = new Program();
        
        int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = inputab[0];
        int m = inputab[1];
        int[] parent = new int[n+1];
        Array.Fill(parent, -1);
        for(int i =0; i < m; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = input[0];
            int b = input[1];
            p.Union(parent, a, b);
        }
        int answer =0;
        foreach(int i in parent)
        {
            if(i < 0)
                answer++;
        }
        Console.Write(answer-1);
    }
    public int Find(int[] parent, int n)
    {
        if(parent[n] < 0)
            return n;
        return parent[n] = Find(parent, parent[n]);
    }
    public void Union(int[] parent, int u, int v)
    {
        u = Find(parent, u);
        v = Find(parent, v);
        if(u == v)
            return;
        if(parent[u] < parent[v])
        {
            parent[v] = u;
        }
        else if(parent[v] < parent[u])
        {
            parent[u] = v;
        }
        else
        {
            parent[v] = u;
            parent[u]--;
        }
    }
}