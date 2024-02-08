using System;
using System.Linq;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        int idx = s1.Length >= s2.Length ? s2.Length : s1.Length;
        if(idx == s1.Length)
        {
            answer = contain(s1, s2, idx);
        }else{
            answer = contain(s2, s1, idx);
        }
        return answer;
        
    }
    
    public int contain(string[] arr, string[] darr, int idx)
    {
        int answer = 0;
        for(int i = 0; i < idx ; i++)
        {
            if(Array.Exists(darr, x => x == arr[i]))
                answer++;
        }
        
        return answer;
    }
}