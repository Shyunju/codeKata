using System;
using System.Collections.Generic;
public class Solution {
    HashSet<int> numberSet = new HashSet<int>();
    public void recursive(string comb, string other){
        if(!comb.Equals(""))
            numberSet.Add(int.Parse(comb));
        for(int i = 0; i < other.Length; i++)
        {
            recursive(comb + other[i], other.Substring(0, i) + other.Substring(i+1));
        }
    }
    public bool isPrime(int num){
        if( num == 0 || num == 1)
            return false;
        int lim = (int)Math.Sqrt(num);
        for(int i = 2; i <= lim; i++)
        {
            if(num % i == 0)
                return false;
        }
        return true;
    }
    public int solution(string numbers) {
        int answer = 0;
        recursive("", numbers);
        foreach(int num in numberSet)
        {
            if(isPrime(num))
                answer++;
        }
        return answer;
    }
}