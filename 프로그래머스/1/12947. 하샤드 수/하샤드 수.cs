public class Solution {
    public bool solution(int x) {
        bool answer = false;
        int num = x;
        int sum = 0;
        while(num > 0){
            sum += num % 10;
            num /= 10;
        }
        if(x % sum == 0)
            answer = true;
        return answer;
    }
}