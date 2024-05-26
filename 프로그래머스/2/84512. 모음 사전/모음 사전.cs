using System;

public class Solution {
    public int solution(string word) {
        int answer = 0;
        string useWords = "AEIOU";
        int[] index =new int[useWords.Length];
        
        index[0] = 1;
        for(int i = 0; ++i< index.Length;)
        {
            index[i] = index[i -1] * useWords.Length + 1;
        }
        Array.Reverse(index);
        for(int i = -1; ++i < word.Length;)
        {
            int wordIndex = useWords.IndexOf(word[i]);
            answer += wordIndex * index[i] +1;
        }
        return answer;
    }
}