using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        //A=65~90 a= 97~122
        foreach(char item in my_string)
        {
            int ascii = Convert.ToInt32(item);
            
            if(ascii < 91)
            {
                answer[ascii - 65]++;
                continue;
            }
            answer[ascii - 97+26]++;
        }
        return answer;
    }
}