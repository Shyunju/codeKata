using System;

public class Solution {
    public int solution(string s) {
        string[] arr = new string[]{};
        arr= s.Split(' ');
        int answer = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(!arr[i].Equals("Z"))
            {
                answer += int.Parse(arr[i]);
            }else{
                answer -=int.Parse(arr[i-1]);
            }
        }
        
        return answer;
    }
}