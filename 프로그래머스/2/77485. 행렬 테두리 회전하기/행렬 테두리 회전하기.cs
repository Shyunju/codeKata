using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int rows, int columns, int[,] queries) {
        int[,] map = new int[rows,columns];
        int count=1;
        for(int i=0; i<rows; i++)
        {
            for(int j=0; j<columns; j++)
            {
                map[i,j]+=count;
                count++;
            }
        }
        int[] answer = new int[queries.GetLength(0)];
         for(int i = 0; i < queries.GetLength(0); i++){
            int[] query =new int[4];
            query[0]= queries[i,0];
            query[1]= queries[i,1];
            query[2]= queries[i,2];
            query[3]= queries[i,3];
            answer[i] = rotation(map,query);
         }
        return answer;
    }
    private int rotation(int [,] m, int [] query) {
        int n = m[query[0]-1, query[3]-1];
        int min = n;
        for (int i = query[3] - 1; i >= query[1]; i--) {
            min = Math.Min(min, m[query[0]-1,i-1]);
            m[query[0] - 1,i] = m[query[0] - 1,i - 1];
        }
        for (int i = query[0]; i < query[2]; i++) {
            min = Math.Min(min, m[i,query[1] - 1]);
            m[i - 1,query[1] - 1] = m[i,query[1] - 1];
        }
        for (int i = query[1]; i < query[3]; i++) {
            min = Math.Min(min, m[query[2] - 1,i]);
            m[query[2] - 1,i - 1] = m[query[2] - 1,i];
        }
        for (int i = query[2] - 1; i >= query[0]; i--) {
            min = Math.Min(min, m[i - 1,query[3] - 1]);
            m[i,query[3] - 1] = m[i - 1,query[3] - 1];
        }
        m[query[0],query[3] - 1] = n;
        return min;
    }
}