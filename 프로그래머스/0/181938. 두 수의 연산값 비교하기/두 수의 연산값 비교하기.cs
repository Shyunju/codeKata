using System;

public class Solution {
    public int solution(int a, int b) {
        string aToStr = a.ToString();
        string bToStr = b.ToString();
        string answerStr = aToStr + bToStr;
        int answerInt = int.Parse(answerStr);
        return answerInt > 2 * a * b ? answerInt : 2 * a * b;
    }
}