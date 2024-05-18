using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        
        for(int i = 0 ; i < clothes.GetLength(0); i++)
        {
            if(dic.ContainsKey(clothes[i, 1]))
                dic[clothes[i, 1]]++;
            else
                dic.Add(clothes[i, 1], 1);  
        }
        foreach(KeyValuePair<string, int> kv in dic)
        {
            answer *= 1 + kv.Value;
        }
        return answer -1;
    }
}