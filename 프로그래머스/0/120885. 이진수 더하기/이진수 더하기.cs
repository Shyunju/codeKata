using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = "";
        int num1 = Convert.ToInt32(bin1, 2);
        int num2 = Convert.ToInt32(bin2, 2);
        
        answer = Convert.ToString(num1 + num2, 2);
        return answer;
    }
}