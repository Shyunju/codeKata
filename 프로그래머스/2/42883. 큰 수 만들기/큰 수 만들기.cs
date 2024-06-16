using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string number, int k) {
        int numSize = number.Length - k;
        List<int> temp = new List<int>(numSize);
        int start = 0;
        for(int i=0; i<numSize; i++) 
        {
        char maxNum = number[start];
        int maxIdx = start;
        for(int j=start; j<=k+i; j++) 
        {
            if(maxNum < number[j]) 
            {
                maxNum = number[j];
                maxIdx = j;
            }
        }
            start = maxIdx + 1;
            temp.Add((int)Char.GetNumericValue(maxNum));
        }
        string answer = string.Join("",temp);
        return answer;
    }
}