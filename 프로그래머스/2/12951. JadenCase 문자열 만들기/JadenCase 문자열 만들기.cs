public class Solution {
    public string solution(string s) {
        char[] charArr = s.ToLower().ToCharArray();
        charArr[0] = char.ToUpper(charArr[0]);
        for(int i = 1; i < charArr.Length; i++)
        {
            if(charArr[i - 1] == ' ')
            {
                charArr[i] = char.ToUpper(charArr[i]);
            }
        }
        string answer = string.Join(string.Empty, charArr);
        return answer;
    }
}