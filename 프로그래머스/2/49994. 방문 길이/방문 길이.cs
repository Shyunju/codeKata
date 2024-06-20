using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string dirs) {
        int answer = 0;
        int[,] load = new int[11, 11];
        int nowy = 5;
        int nowx = 5;
        string[] dir = new string[] {"U", "D", "R", "L"};
        int[] dy = new int[] {-1, 1, 0, 0};
        int[] dx = new int[] {0, 0, 1, -1};
        
        HashSet<string> first = new HashSet<string>();
        
        string[] arrDir = new string[dirs.Length];
        
        for(int i = 0; i < dirs.Length; i++){
            arrDir[i] = dirs[i].ToString();
        }
        
        foreach(string i in arrDir){
            
            int idx = Array.IndexOf(dir, i);
            int nexty = nowy + dy[idx];
            int nextx = nowx + dx[idx];
            
            if(nexty < 0 || nexty >= 11 || nextx < 0 || nextx >= 11)
                continue;
            
            string history = "" + nowy + nowx + nexty + nextx;
            string rhistory = "" + nexty + nextx + nowy + nowx;
            first.Add(history);
            first.Add(rhistory);
            nowy = nexty;
            nowx = nextx;
        }
        return first.Count / 2;
    }
}