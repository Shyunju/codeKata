using System;

public class Solution {
    public int solution(string name) {
        int answer = 0;
        int n = name.Length;
        int leftOrRight = name.Length - 1;
        for (int i = 0; i < n; i++)
        {
            int next = i + 1;
            char target = name[i];
            if (target <= 'N') answer += target - 'A'; //첫 알파벳이 A~N
            else answer += 'Z' - target + 1; //첫 알파벳이  O~Z                
                while (next < n && name[next] == 'A') 
                    next++;
            leftOrRight = Math.Min(leftOrRight, i + n - next + Math.Min(i, n - next));
        }
        answer += leftOrRight;
        return answer;
    }
}