using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] friends, string[] gifts) {
        int answer = 0;
        var dic = new Dictionary<string, int>();
        
        for(int i = 0; i < friends.Length; i++) 
            dic.Add(friends[i], i);
        
        var score = new int[friends.Length];
        var history = new int[friends.Length, friends.Length];
        
        for(int i = 0; i < gifts.Length; i++){
            string[] str = gifts[i].Split(' ');
            history[dic[str[0]], dic[str[1]]]++;
            score[dic[str[0]]]++;
            score[dic[str[1]]]--;
        }
        for(int i = 0; i < friends.Length; i++){
            int num = 0;
            for(int j = 0; j < friends.Length; j++){
                if( i==j) continue;
                if(history[i,j] > history[j,i] || (history[i,j] == history[j,i] && score[i] > score[j]))
                    num++;
            }
            answer = answer < num ? num : answer;
        }
        return answer;
    }
}