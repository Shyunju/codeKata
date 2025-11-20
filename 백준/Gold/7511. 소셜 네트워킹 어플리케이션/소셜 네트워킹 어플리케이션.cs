using System;
using System.IO;
using System.Text;

public class Program
{
    static StreamReader sr = new StreamReader(Console.OpenStandardInput());
    static StringBuilder sb = new StringBuilder();

    public static void Main(string[] args)
    {
        Program p = new Program();

        int scenario = int.Parse(sr.ReadLine());

        for (int i = 0; i < scenario; i++)
        {
            sb.AppendLine($"Scenario {i + 1}:");

            int user = int.Parse(sr.ReadLine());
            int[] parent = new int[user];
            for (int j = 0; j < user; j++)
                parent[j] = -1;

            int relation = int.Parse(sr.ReadLine());
            for (int j = 0; j < relation; j++)
            {
                var line = sr.ReadLine().AsSpan();
                int space = line.IndexOf(' ');
                int a = int.Parse(line.Slice(0, space));
                int b = int.Parse(line.Slice(space + 1));
                p.Union(parent, a, b);
            }

            int question = int.Parse(sr.ReadLine());
            for (int j = 0; j < question; j++)
            {
                var line = sr.ReadLine().AsSpan();
                int space = line.IndexOf(' ');
                int a = int.Parse(line.Slice(0, space));
                int b = int.Parse(line.Slice(space + 1));

                if (p.Find(parent, a) == p.Find(parent, b))
                    sb.AppendLine("1");
                else
                    sb.AppendLine("0");
            }

            if (i < scenario - 1)
                sb.AppendLine();  // 테스트 케이스 사이 빈 줄
        }

        Console.Write(sb.ToString());
    }

    public int Find(int[] parent, int n)
    {
        if (parent[n] < 0)
            return n;
        return parent[n] = Find(parent, parent[n]);
    }

    public void Union(int[] parent, int u, int v)
    {
        u = Find(parent, u);
        v = Find(parent, v);

        if (u == v)
            return;

        // 더 큰 집합을 기준으로 병합 (rank 사용)
        if (parent[v] < parent[u])
        {
            parent[u] = v;
        }
        else if (parent[u] == parent[v])
        {
            parent[v] = u;
            parent[u]--;
        }
        else
        {
            parent[v] = u;
        }
    }
}
