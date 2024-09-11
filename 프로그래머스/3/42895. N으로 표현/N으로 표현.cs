using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int N, int number) {
        if( N == number) return 1;
        HashSet<int>[] dp = new HashSet<int>[9];
        for(int i = 0; i < 9; i++){
            dp[i] = new HashSet<int>();
        }
        dp[1].Add(N);
        for(int i = 2; i <=8; i++){
            string n = "";
            for(int j = 0; j < i; j++){
                n += N.ToString();
            }
            dp[i].Add(int.Parse(n));
            
            for(int k = 1; k < i; k++){
                List<int> firstDp = dp[i-k].ToList();
                List<int> secondDp = dp[k].ToList();
                
                for(int a = 0; a < firstDp.Count; a++){
                    for(int b = 0; b < secondDp.Count; b++){
                        dp[i].Add(firstDp[a] + secondDp[b]);
                        dp[i].Add(firstDp[a] - secondDp[b]);
                        dp[i].Add(firstDp[a] * secondDp[b]);
                        if(secondDp[b] != 0) dp[i].Add(firstDp[a] / secondDp[b]);
                    }
                }
            }
            if(dp[i].Contains(number)) return i;
        }
        return -1;        
    }
}