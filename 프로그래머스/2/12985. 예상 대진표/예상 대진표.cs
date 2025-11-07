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
            A = A % 2 == 0 ? A / 2 : A / 2 + 1;
            B = B % 2 == 0 ? B / 2 : B / 2 + 1;
            answer++;
        }

        return answer;
    }
}