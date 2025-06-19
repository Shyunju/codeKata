using System;

public class Solution {
    public int solution(string[] babbling) {
        string[] bab = {"aya", "ye", "woo", "ma"};
        int answer = 0;
        for(int j = 0;j<babbling.Length; j++)
        {
            for(int i = 0; i < bab.Length; i++)
            {
                babbling[j]= babbling[j].Replace(bab[i], " "); 
            }
            babbling[j] = babbling[j].Replace(" ", "");
            if(babbling[j].Length == 0)
                answer++;
        }
        
        return answer;
    }
}