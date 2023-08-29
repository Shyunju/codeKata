public class Solution {
    public int solution(int num) {
        long n = num;
        int answer = 0;
        int count = 0;
        for (int i = 0; i <= 500 ; i++){
            if( n == 1){
                break;
            }
            if( count == 500){
                return answer = -1;
            }
            if( n % 2 == 0){
                n = n / 2;
                count ++;
            }else{
                n = (n * 3) + 1;
                count++;
            }
            
        }
        return answer = count;
    }
}