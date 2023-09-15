using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] answers) {
        
        int[] one = new int[] {1, 2, 3, 4, 5};
        int[] two = new int[] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] three = new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int[] count = new int[4];
        
        for(int i = 0; i <answers.Length; i++){
            if(answers[i] == one[i % one.Length]) count[1]++;
            if(answers[i] == two[i % two.Length]) count[2]++;
            if(answers[i] == three[i % three.Length]) count[3]++;
        }
        int max = count.Max();
        List<int> list = new List<int>();
        
        for(int i = 1; i <=3; i++){
            if( max == count[i]){
                list.Add(i);
            }
        }
        int[] answer = list.ToArray();
        return answer;
    }
}