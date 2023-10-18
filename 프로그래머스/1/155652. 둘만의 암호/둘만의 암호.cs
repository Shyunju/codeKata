public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        char temp;
      
        for(int  i = 0; i < s.Length; i++)
        {
            temp = s[i];
            for(int j = 0; j < index; )
            {
                temp = (char)((int)temp + 1);
                if(temp > 'z')
                {
                    temp = 'a';
                }
                if(skip.Contains(temp) == true)
                {
                    continue;
                }
                j++;
            }
            answer += temp;
        }
        return answer;
    }
}