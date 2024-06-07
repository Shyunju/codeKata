using System;

public class Solution {
    public int[] solution(int[] numbers) 
    {
        int[] answer = new int[numbers.Length];
        var s = new System.Collections.Generic.Stack<int>();
        for (int i = 0; i < numbers.Length; i++) 
        {
            int n = numbers[i];
            answer[i] = -1;
            while (s.Count > 0) 
            {
                if (numbers[s.Peek()] < n) 
                {
                    answer[s.Peek()] = n;
                    s.Pop();
                }
                else 
                {
                    break;
                }
            }
            s.Push(i);
        }
        return answer;
    }
}