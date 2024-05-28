using System;

public class Solution {
    public int[] solution(int[] sequence, int k) 
{
    int[] answer = new int[2];
    int minLength = int.MaxValue;

    int start = 0;
    int end = 0;
    int curSum = sequence[0];

    while(start < sequence.Length)
    {
        if(curSum < k)
        {
            ++end;

            if(end == sequence.Length)
                break;

            curSum += sequence[end];
        }
        else if(curSum == k)
        {
            // 하나의 쌍을 만들었다.
            int curLength = end - start + 1;
            if(curLength < minLength)
            {
                minLength = curLength;
                answer[0] = start;
                answer[1] = end;
            }

            curSum -= sequence[start];
            ++start;
        }
        else // curSum > k
        {
            curSum -= sequence[start];
            ++start;
        }
    }

    return answer;
}
}