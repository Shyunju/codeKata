using System;
public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int sum =0;
        char[] cArr = x.ToString().ToCharArray();
        for(int i =0; i < cArr.Length; i++){
            sum += int.Parse(cArr[i].ToString());
        }
        if ( x % sum == 0){
            return answer;

        }else{
            return answer = false;
        }
    }
}