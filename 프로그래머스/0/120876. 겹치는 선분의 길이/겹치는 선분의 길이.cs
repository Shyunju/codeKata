using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[,] lines) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for(int i = -100; i <= 100; i++)
        {
            dic.Add(i,0);
        }
        for(int i = 0; i < lines.GetLength(0); i++)
        {
            for(int j = lines[i,0]; j<= lines[i,1] -1; j++)
                dic[j]++;
        }
        
        var list = new List<int>();
        list = dic.Where(w => w.Value >= 2).Select(s=> s.Key).ToList();
        
        if(list.Count == 0) return 0;
        return list.Count;
        
    }
}