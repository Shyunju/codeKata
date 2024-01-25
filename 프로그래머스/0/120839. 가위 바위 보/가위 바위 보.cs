using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string q) {
        char[] answer = new char[]{};
        char[] rsp = new char[]{};
        rsp = q.ToCharArray();
        for(int i = 0; i < rsp.Length; i++)
        {
            if(rsp[i] == '0')
                rsp[i] = '5';
            else if(rsp[i] == '2')
                rsp[i] = '0';
            else
                rsp[i] = '2';
        }
        string result = new string(rsp);
        return result;
    }
}