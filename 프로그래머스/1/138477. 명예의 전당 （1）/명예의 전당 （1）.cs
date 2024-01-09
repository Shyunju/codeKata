using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> board = new List<int>();
        
        for(int i = 0; i < score.Length; i++)
        {
            if(board.Count == k)
            {
                if(board[0] > score[i])
                {
                    answer[i] = board[0];
                    continue;
                }
                board.RemoveAt(0);
            }
            board.Add(score[i]);
            board.Sort();
            answer[i] = board[0];
        }
        return answer;
    }
}