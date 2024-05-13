using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        int length = 0;
        while(!s.Equals("1"))
        {
            answer[0]++;
            length = 0;
            foreach(char i in s)
            {
                if(i == '0')
                    answer[1]++;
                else
                    length++;
            }
            s = Convert.ToString(length, 2);
        }
        return answer;
    }
}