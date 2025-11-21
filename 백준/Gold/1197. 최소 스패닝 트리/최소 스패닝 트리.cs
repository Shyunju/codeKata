using System;
using System.Linq;

public class Program
{    
    public static void Main(string[] args)
    {
        Program p = new Program();
        int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = inputab[0];
        int e = inputab[1];
        int[] parent = new int[n+1];
        Edge[] edges = new Edge[e];
        Array.Fill(parent, -1);
        
        for(int i =0; i < e; i++)
        {
            int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int u = info[0];
            int v = info[1];
            int c = info[2];
            edges[i] = new Edge(u,v,c);
        }
        edges = edges.OrderBy(o => o.c).ToArray();
        int weight = 0;
        for (int i = 0; i < e; i++) {
			Edge now = edges[i];
			if (p.Find(parent, now.u) == p.Find(parent, now.v)) continue;
			weight += now.c;
			p.Union (parent, now.u, now.v);
		}
        Console.Write(weight);
        
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
            parent[v] = u;
        else if(parent[v] < parent[u])
            parent[u] = v;
        else
        {
            parent[v] = u;
            parent[u]--;
        }
    }
}
public class Edge
{
    public int u, v, c;
	public Edge(int u, int v, int c){
		this.u = u;
		this.v = v;
		this.c = c;
	}
}