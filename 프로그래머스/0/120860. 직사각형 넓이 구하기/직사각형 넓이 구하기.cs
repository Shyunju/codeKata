using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int width = 0;
        int height = 0;
        int equal = 0;
        for(int i = 1; i < dots.GetLength(0); i++)
        {
            if(dots[0,0] == dots[i,0]){
                if(dots[0,1] * dots[i,1] < 0) //0을 사이에 둔 좌표
                {
                    height = Math.Abs(0 - dots[0,1]) + Math.Abs(0 - dots[i,1]);
                }else
                    height = Math.Abs(dots[0,1] - dots[i,1]); //음수 확인 후 절댓값반영
                equal = i;
            }else{
                if(dots[0,0] * dots[i,0] < 0) //0을 사이에 둔 좌표
                {
                    width = Math.Abs(0 - dots[0,0]) + Math.Abs(0 - dots[i,0]);
                }else
                    width = Math.Abs(dots[0,0] - dots[i,0]);
                if(equal != 0)
                    break;
            }
        }
        return answer = height * width;
    }
}