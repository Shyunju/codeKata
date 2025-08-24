using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string[] survey, int[] choices) {
        Dictionary<char, int> dic = new Dictionary<char, int>
        {
            {'R', 0}, {'T', 0},{'C',0},{'F',0},{'J',0},{'M',0},{'A',0},{'N',0}
        };
        for(int i = 0; i < survey.Length; i++)
        {
            if( choices[i] == 4)    continue;
            if( choices[i] < 4)
            {
                dic[survey[i][0]] += 4 - choices[i];
            }else{
                dic[survey[i][1]] += choices[i] - 4;
            }
        }
        string answer = "";
        answer += dic['R'] >= dic['T'] ? "R" : "T";
        answer += dic['C'] >= dic['F'] ? "C" : "F";
        answer += dic['J'] >= dic['M'] ? "J" : "M";
        answer += dic['A'] >= dic['N'] ? "A" : "N";
        
        return answer;
    }
}