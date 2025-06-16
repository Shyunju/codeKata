using System;

public class Solution {
    public int solution(int[] common) {
        bool dif = false;
        bool mul = false;
        
        dif = common[1] - common[0] == common[2] - common[1] ? true : false;
        if(Array.IndexOf(common, 0) != -1)
            mul = false;
        else
            mul = common[1] / common[0] == common[2] / common[1] ? true : false;
        
        if(dif)
            return common[common.Length -1] + (common[2] - common[1]);
        if(mul)
            return common[common.Length -1] * (common[2] / common[1]);
        
        return 0;
    }
}