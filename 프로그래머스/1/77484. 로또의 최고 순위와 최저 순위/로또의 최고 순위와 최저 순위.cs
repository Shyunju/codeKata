using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int zero =0;
        int collect =0;
        //0 개수세고 포함숫자 개수세고 최고는 이둘을 더한 결과등수, 최저는 포함개수 등수
        for(int i = 0; i < lottos.Length; i++){
            if(lottos[i] == 0){
                ++zero;
                continue;
            }else if(Array.Exists(win_nums,x => x == lottos[i])){
                ++collect;
                continue;
            }
        }
        answer[0] = 7 - (collect + zero) <= 5 ? 7 - (collect + zero) : 6;
        answer[1] = 7 - collect <= 5 ? 7 - collect : 6;
        return answer;
    }
}