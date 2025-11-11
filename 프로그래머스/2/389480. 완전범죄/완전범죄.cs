using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] info, int n, int m) {
        int a = 0;
        int b = 0;
        List<(int,int)> list = new List<(int, int)>();
        for(int i= 0;i < info.GetLength(0); i++)
        {
            list.Add((info[i,0], info[i,1]));
        }
        list = list.OrderByDescending(o => o.Item1 - o.Item2).ToList();
        
        bool[] visited = new bool[info.GetLength(0)];
        for(int i = 0; i < list.Count; i++)
        {
            if(m > b + list[i].Item2)
            {
                b += list[i].Item2;
                visited[i] = true;
            }
        }
        for(int i = 0; i < list.Count; i++)
        {
            if(visited[i])
                continue;
            if(n > a + list[i].Item1)
            {
                a += list[i].Item1;
                visited[i] = true;
            }
        }
        return Array.IndexOf(visited, false) >= 0 ? -1 : a;
        //return list[0].Item1;
    }
}