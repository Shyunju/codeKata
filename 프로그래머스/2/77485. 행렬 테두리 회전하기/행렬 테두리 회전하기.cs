using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int rows, int columns, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        int[,] matrix = new int[rows, columns];
        int cnt = 1;
        for(int y = 0; y < rows; y++){
            for(int x = 0; x < columns; x++){
                matrix[y, x] = cnt++;
            }
        }
        for(int i = 0; i < queries.GetLength(0); i++){
            Rotate(matrix, queries[i,0] -1, queries[i,1] -1, queries[i,2]-1, queries[i,3] -1, out int min);
            answer[i] = min;
        }
        return answer;
    }
    private void Rotate(int[,] matrix, int y1, int x1, int y2, int x2, out int min){
        if(y1 == y2 && x1 == x2){
            min = matrix[y1, x1];
            return;
        }
        var list = new List<(int y, int x)>();
        
        for(int i = x1; i <= x2; i++) list.Add((y1, i));
        for(int i = y1 +1; i <= y2; i++) list.Add((i, x2));
        for(int i = x2 -1; i >= x1; i--) list.Add((y2, i));
        for(int i = y2 -1; i >= y1; i--) list.Add((i, x1));
        
        int before = int.MaxValue;
        (int y, int x) start = list[0];
        min = matrix[start.y, start.x];
        
        for(int i = 0; i < list.Count; i++){
            (int y, int x) cur = list[i];
            int temp = matrix[cur.y, cur.x];
            matrix[cur.y, cur.x] = before;
            before = temp;
            
            if(temp < min) min = temp;
        }
        
    }
}