using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string num1 = "";
        int num2 = 0;
        foreach(var ch in my_string){
            if(ch< 58){//  숫자
                num1 += ch.ToString();
            }else{
                num2 = 0;
                bool isInt = int.TryParse(num1, out num2);
                answer += num2;
                num1 = "";
            }
        }
        bool final = int.TryParse(num1, out num2);
        if(final)
            answer += num2;
        return answer;
    }
}