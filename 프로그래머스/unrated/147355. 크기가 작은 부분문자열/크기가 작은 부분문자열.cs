using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long member = 0;
        long ip = Int64.Parse(p);
        for(int i = 0; i <= t.Length-p.Length; i++){
            member = Int64.Parse(t.Substring(i, p.Length));
            if(member <= ip){
                answer++;
            }
            member = 0;
        }
        return answer;
    }
}