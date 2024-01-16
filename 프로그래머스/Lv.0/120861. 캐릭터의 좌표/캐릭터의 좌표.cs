using System;
using System.Diagnostics;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[] {0, 0};
        for(int i = 0; i < keyinput.Length; i++){
            if(keyinput[i].Equals("up")){
                if(answer[1] < board[1] / 2)
                    answer[1] += 1;
            }else if(keyinput[i].Equals("down")){
                if(answer[1] > board[1] / 2 * -1)
                    answer[1] -= 1;
            }else if(keyinput[i].Equals("right")){
                if(answer[0] < board[0] / 2)
                    answer[0] += 1;
            }else if(keyinput[i].Equals("left")){
                if(answer[0] > board[0] / 2 * -1)
                    answer[0] -= 1;
            }
        }
        return answer;
    }
}