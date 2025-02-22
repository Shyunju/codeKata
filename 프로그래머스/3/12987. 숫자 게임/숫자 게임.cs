using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
        Array.Sort(A);
        Array.Sort(B);
        //큰수부터 비교한다
        var list = B.ToList();
        for(int i = A.Length-1; i >=0 ; i--){
            if(A[i] >= list[list.Count -1]){
                list.RemoveAt(0);
                continue;
            }
            list.RemoveAt(list.Count-1);
            answer++;
        }
        return answer;
    }
}