public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int sum = 0;
        int count = 0;
        
        for(int i = 0; i < targets.Length; i++)
        {
            for(int j = 0; j < targets[i].Length; j++)
            {
                count = press(keymap, targets[i][j]);
                if(count == -1)
                {
                    sum = -1;
                    break;
                }
                sum += count;
            }
            answer[i] = sum;
            sum = 0;
        }
        return answer;
    }
    
    public int press(string[] keymap, char ch)
    {
        int min = -1;
        
        for(int i = 0; i < keymap.Length; i++)
        {
            for(int j = 0; j < keymap[i].Length; j++)
            {
                if(keymap[i][j] == ch)
                {
                    if(min == -1) min = j + 1;
                    else if(min > j) min = j + 1;
                    break;
                }
            }
        }
        return min;
    }
}