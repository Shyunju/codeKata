public class Solution {
  bool IsPrime(int num)
        {
            for (int i = 2; i * i <= num ; i++)            
                if (num % i == 0)                
                    return false;                            
            return true;
        }
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 2; i <= n; i++)            
                if (IsPrime(i))                
                    answer++;
            return answer;
        }
}