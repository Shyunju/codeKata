using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        for( int i = 1; i< food.Length; i++){
            for(int j = food[i] / 2; j>=0 ; j--){
                if( j == 0)  break;
                answer += i.ToString();
            }
        }
        char[] reverse = answer.ToCharArray();
        Array.Reverse(reverse);
        string sReverse = new string(reverse);
        
        answer += "0" + sReverse;
        return answer;
    }
}