using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] a) {
        int answer = 0;
        if(a.Length == 1) return 0;
        var dic = new Dictionary<int, int>();
        
        foreach(int num in a){
            if(dic.ContainsKey(num))
               dic[num]++;
            else
                dic.Add(num,1);
        }
        foreach(int key in dic.Keys){
            int cnt = 0;
            if(answer > dic[key]) continue;
            
            for(int i = 0; i < a.Length -1; i++){
                if(a[i] != key && a[i+1] != key) continue;
                if(a[i] == a[i+1]) continue;
                
                ++cnt;
                ++i;
            }
            if(answer < cnt) 
                answer = cnt;
        }
        return answer * 2;
    }
}