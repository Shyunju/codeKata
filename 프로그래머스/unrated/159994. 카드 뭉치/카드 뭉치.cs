using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        if ( cards1.Length + cards2.Length < goal.Length)
            return "No";
        int first = 0;
        int second = 0;
        for(int i = 0; i< goal.Length; i++){
            if(first < cards1.Length && goal[i] == cards1[first]){
                first++;
                continue;
            }else if(second < cards2.Length && goal[i] == cards2[second]){
                second++;
                continue;
            }else{
                return "No";
            }
        }
        return answer;
    }
}