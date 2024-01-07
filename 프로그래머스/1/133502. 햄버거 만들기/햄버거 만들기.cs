using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        bool success = true;
        
        int[] recipe = new int[4]{1, 3, 2, 1};
        var stack = new Stack<int>();
        
        for(int i = 0; i < ingredient.Length; i++){
            stack.Push(ingredient[i]);
            
            if(stack.Count() >= 4){
                success = true;
                for( int j = 0; j < 4; j++){
                    if(stack.ElementAt(j) != recipe[j]){
                        success = false;
                        break;
                    }
                }
                if(success){
                    for(int k = 0; k < 4; k++){
                        stack.Pop();
                    }
                    answer++;
                }
            }
        }

        return answer;
    }
}