using System;
public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int tmp;
        if( n > m){
            tmp = n;
            n = m;
            m = tmp;
        }
        int min = UCL(n, m);
        int max = n * m / min;
        
        answer[0] = min; //최대공약수
        answer[1] = max;
        
        return answer;
    }
    public int UCL(int n, int m){
        if(m == 0){
            return n;
        }else{
            return UCL(m, n%m);
        }   
    }
}
