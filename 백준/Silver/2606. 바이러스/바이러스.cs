//첫째 줄에는 컴퓨터의 수가 주어진다. 컴퓨터의 수는 100 이하인 양의 정수이고 각 컴퓨터에는 1번 부터 차례대로 
//번호가 매겨진다. 둘째 줄에는 네트워크 상에서 직접 연결되어 있는 컴퓨터 쌍의 수가 주어진다. 
//이어서 그 수만큼 한 줄에 한 쌍씩 네트워크 상에서 직접 연결되어 있는 컴퓨터의 번호 쌍이 주어진다.

//1번 컴퓨터가 웜 바이러스에 걸렸을 때, 1번 컴퓨터를 통해 웜 바이러스에 걸리게 되는 컴퓨터의 수를 첫째 줄에 출력한다.
using System;
using System.IO;
using System.Linq;

public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    public static void Main(string[] args)
    {
        Program p = new Program();
        int com = int.Parse(sr.ReadLine());
        int[] parent = new int[com+1];
        Array.Fill(parent, -1);
        
        int relation = int.Parse(sr.ReadLine());
        for(int i= 0; i < relation; i++)
        {
            var line = sr.ReadLine().AsSpan();
            int space = line.IndexOf(' ');
            int a = int.Parse(line.Slice(0, space));
            int b = int.Parse(line.Slice(space + 1));
            p.Union(parent, a, b);
        }
        int root = p.Find(parent, 1);
        int answer = 0;
        for(int i= 2; i < com+1; i++)
        {
            if(p.Find(parent, i) == root)
                answer++;
        }
        Console.Write(answer);
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
        else if(parent[u] == parent[v])
        {
            parent[v] = u;
            parent[u]--;
        }
        else
        {
            parent[u] = v;
        }
    }
}