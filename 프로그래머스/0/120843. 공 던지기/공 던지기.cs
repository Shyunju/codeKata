public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int ball = 1;
        
        for(int i = 0; i < k - 1; i++)
        {
            if(ball + 2 > numbers.Length)
            {
                ball += 2;
                ball -= numbers.Length;
            }
            else
            {
                ball += 2;
            }
        }
        answer = ball;
        return answer;
    }
}