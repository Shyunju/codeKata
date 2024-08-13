using System;
 
public class Solution {
    int[,] temp;
    int[] answer = new int[]{0,0};
    public int[] solution(int[,] arr) {
        temp=arr;
        Function(0,0,arr.GetLength(0));
        return answer;
    }
    
    public void Function(int startx,int starty,int sideLength)
    {   
        bool AllZero=true;
        bool AllOne=true;
        for (int i = startx; i < startx + sideLength; i++)
        {
            for (int j = starty; j < starty + sideLength; j++)
            {
                if (temp[i,j] == 0)
                {
                    AllOne = false;
                }
                if (temp[i,j] == 1)
                {
                    AllZero = false;
                }
            }
        }
        if (AllZero == true)
        {
            answer[0]++;
            return;
        }
        if (AllOne == true)
        {
            answer[1]++;
            return;
        }
        Function(startx, starty, sideLength / 2);
        Function(startx, starty + sideLength / 2, sideLength / 2);
        Function(startx + sideLength / 2, starty, sideLength / 2);
        Function(startx + sideLength / 2, starty + sideLength / 2, sideLength / 2);
    }
}