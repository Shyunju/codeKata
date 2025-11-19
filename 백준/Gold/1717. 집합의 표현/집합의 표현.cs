using System;
public class Program
{
    public static void Main(string[] args)
    {
        Program p = new Program();
        string[] sl = Console.ReadLine().Split();
        int n = int.Parse(sl[0]);
        int m = int.Parse(sl[1]);
        int[] parent = new int[n+1];
        for(int i = 0; i < n+1; i++)
        {
            parent[i] = -1;
        }
        for(int i = 0; i < m; i++)
        {
            string[] order = Console.ReadLine().Split();
            int o = int.Parse(order[0]);
            int u = int.Parse(order[1]);
            int v = int.Parse(order[2]);
            if(o == 0)
            {
                p.Union(u, v, parent);
                continue;
            }
            if(p.Find(parent, u) == p.Find(parent, v))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        
    }
    public int Find(int[] parent, int n)
    {
        if(parent[n] < 0)
            return n;
        return parent[n] = Find(parent, parent[n]);
    }
    public void Union(int u, int v, int[] parent)
    {
        u = Find(parent, u);
        v = Find(parent, v);
        if(u == v)
            return;
        if(parent[v] < parent[u])
        {
            int temp = u;
            u = v;
            v = temp;
        }
        if(parent[u] == parent[v])
        {
            parent[u]--;
        }
        parent[v] = u;
        return;
    }
}