using System;

public class Solution {
    long[] numbers;
    public int[] solution(long[] numbers) {
        this.numbers = numbers;
        int[] answer = new int[numbers.Length];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            string convertedBinary = Convert.ToString(numbers[i], 2); // 1. 10진수 -> 2진수
            int height = 0;
            double temp = 1;
            // 2. 포화 이진트리로 만들기
            // height => 노드 개수 : 2^0 + .. + 2^(height-1)
            while (convertedBinary.Length > temp)
            {
                height += 1;
                temp += Math.Pow(2, height); 
            }
            // 앞에 0 붙이기
            convertedBinary = new String('0', (int)temp - convertedBinary.Length) + convertedBinary;
        
            if (IsValid(convertedBinary)) answer[i] = 1;
        }
        
        return answer;
    }
    
    public bool IsValid(string number)
    {
        bool isValid = true;
        
        int mid = (number.Length - 1) / 2;
        char root = number[mid];
        string left = number.Substring(0, mid);
        string right = number.Substring(mid + 1, mid);
        
        // 부모가 0인데 자식 중 하나가 1이면 이진트리 성립 x
        if(root == '0' && (left[(left.Length - 1) / 2] == '1' || right[(right.Length - 1) / 2] =='1'))
        {
			return false;
		}
        
        // 트리 타고 가면서 이진 트리 가능한지 확인하기 
        if(left.Length >= 3) 
        {
			isValid = IsValid(left);
			if(isValid) isValid = IsValid(right);
		}
        
		return isValid;
    }
}
