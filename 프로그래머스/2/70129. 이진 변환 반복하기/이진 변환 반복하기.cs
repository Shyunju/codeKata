using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        int count = 0;
        int length = 0;
        int turn = 0;
        while(!s.Equals("1"))
        {
            turn++;
            length = 0;
            foreach(char i in s)
            {
                if(i == '0')
                    count++;
                else
                    length++;
            }
            s = Convert.ToString(length, 2);
        }
        answer[0] = turn;
        answer[1] = count;
        return answer;
    }
}