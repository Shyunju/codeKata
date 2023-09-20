using System;
using System.Linq;
public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int count = 0;
        int[] attack = new int[number+1];
        
        for(int i = 1; i <= number; i++){
            count = 1;
            for(int j = 1; j <= i/2 ; j++){
                if( i % j == 0){
                    count++;
                }
            }
            if(count > limit){
                count = power;
            }
            attack[i] = count;
        }
        answer = attack.Sum();
        return answer;
        //약수의 갯수를 담는 number+1만큼의 배열
        //배열의 원소가 limit보다 크면 power로 대체
        //배열의 모든 원소의 합 반환
    }
}