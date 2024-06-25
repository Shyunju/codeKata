using System;
using System.Linq;
public class Solution {
    public int solution(string name) {
        int answer = int.MaxValue;
        bool[] visited = name.Select(s=> s== 'A').ToArray();
        
        DFS(name, visited, 0, 0, ref answer);
        return answer;
    }
    public void DFS(string name, bool[] visited, int cur, int count, ref int answer){
        if(!visited[cur]){
            int up = name[cur] - 'A';
            int down = 'Z'-'A' -up +1;
            count += Math.Min(up, down);
            visited[cur] = true;
        }
        if(visited.Count(c=>!c) ==0){
            if(count < answer)
                answer=count;
            return;
        }
        
        int left = cur;
        int leftCount = 0;
        while(visited[left]){
            leftCount++;
            left = left >0 ? left -1 : (left + name.Length -1) % name.Length;
        }
        
        int right = cur;
        int rightCount = 0;
        while(visited[right]){
            rightCount++;
            right = right < name.Length -1? right + 1 : (right +1) % name.Length;
        }
        
        DFS(name, visited, left, count + leftCount, ref answer);
        visited[left] = false;
        
        DFS(name, visited, right, count + rightCount, ref answer);
        visited[right] = false;
    }
}