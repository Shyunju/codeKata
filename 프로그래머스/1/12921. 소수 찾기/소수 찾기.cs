using System;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        bool[] sosu =new bool [n+1];
        for(int i=2; i<=n ; i++) sosu[i]=true;
        int root=(int)Math.Sqrt(n);
        for(int i=2; i<=root; i++){ 
            if(sosu[i]==true){ 
                for(int j=i; i*j<=n; j++)
                    sosu[i*j]=false;
            }
        } for(int i =2; i<=n; i++) 
        { 
            if(sosu[i]==true) answer++;
         }
        return answer;
    }
}