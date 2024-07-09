using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[(n*(n+1))/2]; //배열의 총크기
        int[,] temp = new int[n,n];         //2차원 배열

        int x = -1, y = 0;
        int num = 1;

        for (int i = 0; i < n; i++) {
            for (int j = i; j < n; j++) { 	
                if (i % 3 == 0) {         //왼쪽대각선으로 진행시
                    x++;
                } else if (i % 3 == 1) {  //오른쪽으로 진행시
                    y++;
                } else if (i % 3 == 2) {  //오른쪽 대각선 진행시
                    x--;
                    y--;
                }
                temp[x,y] = num++;
            }
        }
        int k = 0;
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < n; j++) {
                if(temp[i,j] == 0) 
                	break;
                answer[k++] = temp[i,j];
            }
        }
        return answer;
    }
}