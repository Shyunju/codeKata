using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 1;
        int A = Math.Min(a,b);
        int B = Math.Max(a,b);
        while(true)
        {
            if(B-A == 1 && B % 2 == 0)
                break;
            
            if(A % 2 == 0)
                A /= 2;
            else
                A = A / 2 + 1;
            
            if(B % 2 == 0)
                B /= 2;
            else
                B = B / 2 + 1;
            answer++;
        }

        return answer;
    }
}