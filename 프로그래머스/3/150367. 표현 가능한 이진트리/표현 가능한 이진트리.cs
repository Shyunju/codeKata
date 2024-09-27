using System;

public class Solution {
    long[] numbers;
    public int[] solution(long[] numbers) {
        this.numbers = numbers;
        int[] answer = new int[numbers.Length];
        
        for(int i = 0; i < numbers.Length; i++){
            string NtoB = Convert.ToString(numbers[i], 2);
            int deep = 0;
            double temp = 1;
            
            while(NtoB.Length > temp){
                ++deep;
                temp += Math.Pow(2, deep);
            }
            NtoB = new String('0', (int)temp - NtoB.Length) + NtoB;
            if(IsValid(NtoB)) answer[i] = 1;
        }
        return answer;
    }
    private bool IsValid(string NtoB){
        bool valid = true;
        int mid = (NtoB.Length-1) / 2;
        char root = NtoB[mid];
        string left = NtoB.Substring(0, mid);
        string right = NtoB.Substring(mid + 1, mid);
        
        if( root == '0' && (left[(left.Length-1) / 2] == '1' || right[(right.Length-1)/2] == '1'))
            return false;
        if(left.Length >= 3){
            valid = IsValid(left);
            if(valid)
                valid = IsValid(right);
        }
        return valid;
    }
}