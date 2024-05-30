using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {

    int count = 0;
    int result = 0;

    public int solution(string word) {

        dfs("", word);

        return result;
    }

    public void dfs(string s, string word)
        {
            char[] alphabet = new char[] { 'A', 'E', 'I', 'O', 'U' };
            Stack<char> stack = new Stack<char>(s.ToArray());

            if (s == word)
            {
                result = count;
                return;
            }

            if (stack.Count() == 5) return;

            for (int i = 0; i < 5; i++)
            {
                stack.Push(alphabet[i]);
                count++;

                string nextWord = string.Join("", stack.ToArray().Reverse());

                dfs(nextWord, word);                

                stack.Pop();
            }
        }
}