using System;

public class Solution {
    int[,] temp;
    int[] answer = new int[2];
    public int[] solution(int[,] arr) {
        temp = arr;
        Quad(0, 0, arr.GetLength(0));
        return answer;
    }
    private void Quad(int starty, int startx, int side)
    {
        bool isZero = true;
        bool isOne = true;
        
        for(int i = starty; i < starty + side; i++){
            for(int j = startx; j < startx + side; j++){
                if(temp[i,j] == 0) isOne = false;
                else isZero = false;
            }
        }
        if(isZero){
            ++answer[0];
            return;
        }
        if(isOne){
            ++answer[1];
            return;
        }
        
        //1
        Quad(starty, startx, side /2);
        //2
        Quad(starty, startx + side / 2, side /2);
        //3
        Quad(starty + side / 2, startx, side /2);
        //4
        Quad(starty + side / 2, startx + side / 2, side / 2);
    }
}