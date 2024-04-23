using System;
using System.Linq;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        foreach(string dicC in dic)
        {
            bool check = true;
            foreach(string spellC in spell)
            {
                if(dicC.IndexOf(spellC) == -1)
                {
                    check = false;
                    break;
                }
            }
            if(check == true)
            {
                answer = 1;
                break;
            }
        }
        return answer;
    }
}