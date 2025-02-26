using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        string a = "";
        string b = "";
        foreach(int i in num_list){
            if(i % 2 == 0)
                a += i.ToString();
            else
                b += i.ToString();
        }
        answer = int.Parse(a) + int.Parse(b);
        return answer;
    }
}