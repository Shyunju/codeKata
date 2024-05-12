using System;
using System.Collections.Generic;
using System.Text;
class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
        List<string> past = new List<string>();
        string first = "";
        string last = "";
        
        int count = 0;
        int turn = 1;
        foreach(string word in words)
        {
            count++;
            if(count == 1)
            {
                past.Add(word);
                last = word[word.Length -1].ToString();
                continue;
            }
            if(count % n == 1)
                turn++;
            first = word[0].ToString();
            int check = past.IndexOf(word);
            if(check == -1 && last.Equals(first))
            {
                past.Add(word);
                last = word[word.Length -1].ToString();
            }else{
                if(count % n == 0)
                    answer[0] = n;
                else
                    answer[0] = count % n;
                answer[1] = turn;
                break;
            }
        }
        return answer;
    }
}