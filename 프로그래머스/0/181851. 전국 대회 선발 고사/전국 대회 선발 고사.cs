using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        var result = new List<(int,int)>();
        for(int i = 0; i < rank.Length; i++)
        {
            if(attendance[i])
                result.Add((rank[i], i));
        }
        result.Sort();
        return 10000 * result[0].Item2 + 100 * result[1].Item2 + result[2].Item2;
    }
}