using System;
using System.Text;
public class Solution {
    public string solution(string cipher, int code) {
        StringBuilder answer = new StringBuilder();
        for(int i = code -1; i<cipher.Length; i += code)
        {
            answer.Append(cipher[i]);
        }
        return answer.ToString();
    }
}