using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for(int i = 1; i <= players.Length; i++)
        {
            dic.Add(players[i-1], i);
        }
        foreach(string name in callings)
        {
            int rank = dic[name] -1;
            string temp = players[rank-1];
            players[rank] = players[rank-1];
            players[rank -1] = name; 
            
            dic[temp]++;
            dic[name]--;
        }
        return players;
    }
}