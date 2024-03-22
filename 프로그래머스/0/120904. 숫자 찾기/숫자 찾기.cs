using System;

public class Solution {
    public int solution(int num, int k) {
        string answer = num.ToString();
        int idx = -1; 
        if(answer.Contains(k.ToString()))
        {
            idx = answer.IndexOf(k.ToString()) + 1;
        }
        return idx;
    }
}