public class Solution {
    public int[] solution(long n) {
        
        long ten = 1;
        long num = 0;
        int count = 0;
        for(int i =0; i < 12 ; i++){
            if( n / ten == 0){
                break;
            }else{
                ten = ten * 10;
                count++;
            }
        }
        ten = ten / 10;
        int[] answer = new int[count];
        for( int i= count-1; i >= 0; i--){
            if( n > 0){
                num = n / ten;
                answer[i] = (int)num;
                n = n % ten;
                ten = ten / 10;
            }else if( ten >= 1 && n == 0){
                answer[i] = 0;
            }else{
                break;
            }
        }
        
        return answer;
    }
}