using System;
public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        for(int n = i; n <= j; n++)
        {
            if(n.ToString().Contains(k.ToString()))
            {
                foreach(char num in n.ToString())
                {
                    if(num.ToString() == k.ToString())
                        answer++;
                }
            }
        }
        return answer;
    }
}