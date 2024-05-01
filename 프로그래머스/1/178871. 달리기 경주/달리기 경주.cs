using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for(int i = 0; i < players.Length; i++)
        {
            dic.Add(players[i], i);            
        }
        foreach(string name in callings)
        {
            int rank = dic[name];
            string temp = players[rank -1];
            
            players[rank -1] = name;
            players[rank] = temp;
            
            dic[name] -= 1;
            dic[temp] += 1;
        }
        return players;
    }
}