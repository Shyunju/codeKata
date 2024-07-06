using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        
        List<List<int>> list = new List<List<int>>();
        
        for (int i = 0; i < n; i++)
        {
            list.Add(new List<int>());
        }

        NTriangle(ref list, 0, 1, n);

        List<int> newList = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list[i].Count; j++)
            {
                newList.Add(list[i][j]);
            }
        }
        
        return newList.ToArray();
    }
    
    public void NTriangle(ref List<List<int>> list, int depth, int startNumber, int n)
    {
        if (n <= 0) return;

        for (int i = 0; i < n; i++)
        {
            list[i + (depth * 2)].Insert(depth, startNumber++);
        }

        for (int i = 0; i < n - 1; i++)
        {
            var index = list[n - 1 + (depth * 2)].Count;
            list[n - 1 + (depth * 2)].Insert(index - depth, startNumber++);
        }

        for (int i = 0; i < n - 2; i++)
        {
            list[n - (i + 2) + (depth * 2)].Insert(1 + depth, startNumber++);
        }

        NTriangle(ref list, depth + 1, startNumber, n - 3);
    }
}
