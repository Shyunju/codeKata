public class Solution {
    public int solution(int n) {
        int f1 = 1;
        int f2 = 1;
        int answer = 0;
        if(n == 2)
            return 1;
        for(int i = 3; i <= n; i++)
        {
            answer = (f1 + f2) % 1234567;
            f2 = f1;
            f1 = answer;
        }
        return answer;
    }
    
    
}