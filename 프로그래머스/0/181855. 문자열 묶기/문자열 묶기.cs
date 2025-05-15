using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] strArr) {
        var dic = new Dictionary<int, int>();
        int length = 0;
        foreach(string i in strArr)
        {
            length = i.Length;
            if(!dic.ContainsKey(length))
            {
                dic.Add(length, 1);
                continue;
            }
            dic[length]++;
        }
        return dic.OrderByDescending(x => x.Value).First().Value;
    }
}