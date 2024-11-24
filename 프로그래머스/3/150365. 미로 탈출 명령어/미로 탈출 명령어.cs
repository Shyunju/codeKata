using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    Dictionary<string, int> route = new Dictionary<string, int>{
        {"d", 0}, {"u", 0}, {"r", 0}, {"l", 0}
    };
    public string solution(int n, int m, int x, int y, int r, int c, int k) {
        string answer = "";
        int dist = Math.Abs(x-r) + Math.Abs(y-c);
        k -= dist;
        if(k < 0 || k % 2 != 0) return "impossible";
        else{
            if(x > r) route["u"] = x -r;
            else route["d"] = r -x;
            
            if(y > c) route["l"] = y - c;
            else route["r"] = c - y;
            
            int d = Math.Min(k /2, n - (x + route["d"]));
            route["d"] += d;
            route["u"] += d;
            k -= d* 2;
            
            int l = Math.Min(k/2, y - route["l"] - 1);
            route["l"] += l;
            route["r"] += l;
            k -= l * 2;
            
            answer = answer.PadRight(answer.Length + route["d"], 'd');
            answer = answer.PadRight(answer.Length + route["l"], 'l');
            
            for(int i = k /2 ; i>0; i--) answer = answer + "rl";
            answer = answer.PadRight(answer.Length + route["r"], 'r');
            answer = answer.PadRight(answer.Length + route["u"], 'u');
        }
        return answer;
    }
}