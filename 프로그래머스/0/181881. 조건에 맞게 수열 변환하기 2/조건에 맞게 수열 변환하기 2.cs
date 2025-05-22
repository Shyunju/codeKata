using System;

public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        int changeCnt = 0;
        int temp;
        while(true)
        {
            changeCnt = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                if(arr[i] >= 50 && arr[i] % 2 == 0)
                {
                    arr[i] /= 2;
                }else if(arr[i] < 50 && arr[i] % 2 == 1)
                {
                    arr[i] = arr[i] * 2 + 1;
                }
                if(temp != arr[i])  changeCnt++;
            }
            if(changeCnt == 0)
                break;
            answer++;
        }
        return answer;
    }
}