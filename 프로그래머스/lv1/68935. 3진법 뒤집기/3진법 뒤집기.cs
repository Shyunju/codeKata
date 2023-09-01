using System;
using static System.Math;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> list = new List<int>();
        
        //자연수 n이 0이 될 때 까지 나눈 나머지를 list에 저장
        while(true)
        {
            if(n==0) break;
            int d = n%3;
            list.Add(d);
            n = n/3;
        }
        //앞뒤 뒤집기 list.Reverse()
        list.Reverse();
        
        //뒤집은 list의 나머지 값 * 3의 거듭 제곱을 곱해 answer에 더하기
        for(int i = 0; i<list.Count; i++)
        {
            answer += (int)(list[i] * Math.Pow(3,i));
        }
        return answer;
    }
   
}