using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] str_list) {
        var answer = new List<String>();
        int l = Array.IndexOf(str_list,"l");
        int r = Array.IndexOf(str_list,"r");
        int idx = -1;
        if(l != -1 && (l < r || r == -1)){
            idx = l;
            for(int i = 0; i < l; i++)
                answer.Add(str_list[i]);
        }
        else if( r != -1 && (r < l || l == -1)){
            idx = r;
            for(int i = r+1; i < str_list.Length; i++)
                answer.Add(str_list[i]);
        }
        return answer.ToArray();
        
    }
}