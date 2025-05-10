using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length == 1)
            return arr;
        var answer = arr.ToList();
        int cnt = 0;
        int pow = 2;
        while(pow < arr.Length)
        {
            pow *= 2;
        }
        cnt = pow - arr.Length;
        for(int i = 1; i <= cnt; ++i)
        {
            answer.Add(0);
        }
        return answer.ToArray();
    }
}