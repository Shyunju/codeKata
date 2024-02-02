using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        for(int i =0; i < board.GetLength(0); i++)
        {
            for(int j = 0; j<board.GetLength(0); j++)
            {
                if(board[i,j] == 1)
                {
                    for(int k = -1; k <= 1; k++)
                    {
                        if(-1 < i+k && i+k < board.GetLength(0))
                        {
                            for(int l = -1; l <= 1; l++)
                            {
                                if(-1 < j+l && j+l < board.GetLength(0))
                                {
                                    if(board[i+k,j+l] != 1)
                                        board[i+k,j+l] = 2;
                                }
                            }
                        }
                    }
                }
            }
        }
        foreach(int item in board){
            if( item == 0)
                answer++;
        }
        return answer;
    }
}