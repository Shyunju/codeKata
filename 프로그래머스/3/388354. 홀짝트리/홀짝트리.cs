using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] nodes, int[,] edges) {
        int n = nodes.Length;
        // map node value -> index 0..n-1
        var idx = new Dictionary<int,int>(n);
        for (int i = 0; i < n; ++i) idx[nodes[i]] = i;

        // union-find
        int[] parent = new int[n];
        int[] rank = new int[n];
        for (int i = 0; i < n; ++i) { parent[i] = i;}

        int[] degree = new int[n];

        int m = edges.GetLength(0);
        for (int i = 0; i < m; ++i) {
            int aVal = edges[i,0];
            int bVal = edges[i,1];
            int a = idx[aVal];
            int b = idx[bVal];
            degree[a]++; degree[b]++;
            Union(parent, rank, a, b);
        }

        // group nodes by root
        var groups = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; ++i) {
            int r = Find(parent, i);
            if (!groups.ContainsKey(r)) groups[r] = new List<int>();
            groups[r].Add(i);
        }

        int oddEvenTrees = 0;
        int inverseOddEvenTrees = 0;

        foreach (var kv in groups) {
            var list = kv.Value;
            int size = list.Count;
            int countEq = 0; // nodes where nodeParity == degreeParity
            foreach (int i in list) {
                int nodeVal = nodes[i];
                int nodeParity = nodeVal & 1; // 1 if odd, 0 if even
                int degParity = degree[i] & 1;
                if (nodeParity == degParity) countEq++;
            }
            if (countEq == 1) oddEvenTrees++;
            if (countEq == size - 1) inverseOddEvenTrees++;
        }

        return new int[]{ oddEvenTrees, inverseOddEvenTrees };
    }

    private int Find(int[] parent, int x) {
        if (parent[x] != x) parent[x] = Find(parent, parent[x]);
        return parent[x];
    }

    private void Union(int[] parent, int[] rank, int x, int y) {
        int rx = Find(parent, x);
        int ry = Find(parent, y);
        if (rx == ry) return;
        if (rank[rx] < rank[ry]) parent[rx] = ry;
        else if (rank[ry] < rank[rx]) parent[ry] = rx;
        else { parent[ry] = rx; rank[rx]++; }
    }
}
