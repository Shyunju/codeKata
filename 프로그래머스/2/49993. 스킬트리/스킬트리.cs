using System;

public class Solution {
    public int solution(string skill, string[] skill_trees) {
        int answer = 0;
        int now = 0;
        bool possible = true;
        foreach(string i in skill_trees){
            now = 0;
            possible = true;
            for(int j= 0; j <i.Length; j++){
                int idx = skill.IndexOf(i[j]);
                if(idx == -1)
                    continue;
                if(idx == now){
                    now++;
                    continue;
                }else{
                    possible = false;
                    break;
                }
            }
            answer += possible ? 1 : 0;
        }
        return answer;
    }
}