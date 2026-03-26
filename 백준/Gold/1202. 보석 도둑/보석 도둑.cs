using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class Program
{
    struct Gem {
        public int Weight;
        public int Value;
    }

    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        string[] input = reader.ReadLine().Split();
        int n = int.Parse(input[0]); // 보석 개수
        int k = int.Parse(input[1]); // 가방 개수

        Gem[] gems = new Gem[n];
        for (int i = 0; i < n; i++)
        {
            string[] g = reader.ReadLine().Split();
            gems[i] = new Gem { Weight = int.Parse(g[0]), Value = int.Parse(g[1]) };
        }

        int[] bags = new int[k];
        for (int i = 0; i < k; i++)
        {
            bags[i] = int.Parse(reader.ReadLine());
        }

        Array.Sort(gems, (a, b) => a.Weight.CompareTo(b.Weight));
        Array.Sort(bags);

        // 최대 힙 (가격이 높은 보석이 우선순위)
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        
        long totalValue = 0;
        int gemIdx = 0;

        // 작은 가방부터 순회
        for (int i = 0; i < k; i++)
        {
            // 현재 가방에 넣을 수 있는 보석들을 모두 큐에 담음
            while (gemIdx < n && gems[gemIdx].Weight <= bags[i])
            {
                pq.Enqueue(gems[gemIdx].Value, gems[gemIdx].Value);
                gemIdx++;
            }

            // 큐에서 가장 비싼 보석 하나를 꺼내서 가방에 담음
            if (pq.Count > 0)
            {
                totalValue += pq.Dequeue();
            }
        }

        Console.WriteLine(totalValue);
    }
}