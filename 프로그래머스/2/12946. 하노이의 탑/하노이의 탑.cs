using System;
using System.Collections.Generic;

public class Solution {
    public int[,] solution(int n) 
    {
        var list = new List<(int, int)>();

        Hanoi(list, n, 1, 3, 2);

        int[,] answer = new int[list.Count, 2];
        for(int i = 0; i < list.Count; ++i)
        {
            answer[i, 0] = list[i].Item1;
            answer[i, 1] = list[i].Item2;
        }

        return answer;
    }

    private void Hanoi(List<(int, int)> list, int n, int start, int end, int sub)
    {
        if(n == 1) 
        {
            Move(list, start, end);
            return;
        }

        Hanoi(list, n - 1, start, sub, end);
        Move(list, start, end); 
        Hanoi(list, n - 1, sub, end, start); 
    }

    private void Move(List<(int, int)> list, int start, int end)
    {
        list.Add((start, end));
    }

}