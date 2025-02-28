using System;
using System.Linq;
public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int n = arr1.Length;
        int m = arr2.Length;
        if(n > m) return 1;
        else if(m > n) return -1;
        else{
            int sum1 = arr1.Sum();
            int sum2 = arr2.Sum();
            
            if(sum1 > sum2) return 1;
            else if(sum1 == sum2) return 0;
            else return -1;
        }
    }
}