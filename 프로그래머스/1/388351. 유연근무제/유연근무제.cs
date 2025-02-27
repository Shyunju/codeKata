using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        int n = schedules.Length;
        bool check = true;
        for(int i = 0; i < n; i++){
            int wish = schedules[i] + 10;
            if(wish % 100 >= 60){
                wish += 40;
            }
            check = true;
            for(int j = 0; j < 7; j++){
                
                if((j+startday) % 7 == 6 || (j+startday) % 7 == 0)
                    continue;
                if(wish < timelogs[i,j]){ //지각
                    check = false;
                    break;
                }
            }
            if(check)
                answer++;
        }
        return answer;
    }
}