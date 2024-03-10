using System;

public class Solution {
    public int solution(string[] order) { 
        int answer = 0;
        foreach(string idx in order)
        {       
            string menu = idx.Replace("hot", "");
            menu = menu.Replace("ice","");
            
            if(menu == "cafelatte")
                answer += 5000;
            else
                answer += 4500;
        }
        return answer;
    }
}