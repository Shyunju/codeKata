using System;
using System.Diagnostics;

public class Solution {
public int[] solution(int[,] edges)
    {

        int nodeCnt = 0;
        int lineCnt = edges.GetLength(0);
        for (int i = 0; i < lineCnt; i++)
        {
            if (edges[i, 0] > nodeCnt)
                nodeCnt = edges[i, 0];

            if (edges[i, 1] > nodeCnt)
                nodeCnt = edges[i, 1];
        }

        int[] answer = new int[4];
        int[,] lines = new int[nodeCnt+1, 2];
        bool[] exist = new bool[nodeCnt+1];
        for (int i = 0; i < lineCnt; ++i)
        {
            // start >=2 && end < 1
            int start = edges[i,0];
            int end = edges[i,1];
            exist[start] = true;
            exist[end] = true;
            lines[start, 0]++;
            lines[end, 1]++;

            if (lines[start, 0] >= 2 && lines[start, 1] < 1)
            {
                answer[0] = start;
                
            }
            else if (lines[end, 0] >= 2 && lines[end, 1] < 1)
            {
                answer[0] = end;
            }


        }

        // 
        for (int i = 1; i < nodeCnt+1 ; ++i)
        {
            if (answer[0] == i || exist[i] == false)
                continue;

            if (lines[i, 0] == 0)
            {
                answer[2]++;
            }
            else if (lines[i, 0] >= 2 && lines[i, 1] >= 2)
            {
                answer[3]++;
            }
        }

        answer[1] = lines[answer[0], 0] - answer[2] - answer[3];
        
        return answer;
    }
}