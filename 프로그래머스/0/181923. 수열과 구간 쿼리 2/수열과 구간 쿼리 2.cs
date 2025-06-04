using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i,0];
            int e = queries[i,1];
            int k = queries[i,2];
            int min = 1000000;
            for(int j = s; j <= e; j++)
            {
                if(arr[j] > k && arr[j] < min)
                    min = arr[j];
            }
            if(min != 1000000)
                answer[i] = min;
            else
                answer[i] = -1;
        }
        return answer;
    }
}