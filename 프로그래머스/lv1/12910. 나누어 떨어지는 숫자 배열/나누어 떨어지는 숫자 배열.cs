using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> div = new List<int>();
        
        foreach( var item in arr){
            if( item % divisor == 0){
                div.Add(item);
            }
        }
        if( div.Count == 0){
            div.Add(-1);
        }else{
            div.Sort();
        }
        return div.ToArray();
    }
}