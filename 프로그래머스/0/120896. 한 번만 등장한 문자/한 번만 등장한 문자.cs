using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int count = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            for(int j = 0; j < s.Length; j++)
            {
                if(s[i] == s[j])
                {
                    count++;
                }
            }
            if(count == 1)
            {
                answer += s[i];
            }
            count = 0;
        }
        answer = string.Concat(answer.OrderBy(x => x));
        return answer;
    }
}