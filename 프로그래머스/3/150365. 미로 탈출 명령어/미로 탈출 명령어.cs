using System;
using System.Text;

public class Solution {
    public int[] dx = {1, 0, 0, -1};
    public int[] dy = {0, -1, 1, 0};
    public char[] dir = {'d', 'l', 'r', 'u'};
    public int m;
    public int n;
    public StringBuilder sb;
    public int targetX;
    public int targetY;
    public string answer;
    
    public string solution(int n, int m, int x, int y, int r, int c, int k) {
        this.m = m;
        this.n = n;
        targetX = r;
        targetY = c;        
        sb = new StringBuilder();
        answer = "";
        
        int length = GetDist(x, y, r, c);
        // k, 도착지점까지 거리 짝, 홀 일치 하지 않으면 impossible
        // 이동 가능한 거리가 도착지점보다 짧으면 impossible
        if((k - length) % 2 == 1 || k < length) return "impossible";
        
        DFS(x, y, 0, k);
        return answer == "" ? "impossible" : answer;
    }
    
    // 현재 위치 (x, y) ~ 도착지점까지 거리
    private int GetDist(int x, int y, int r, int c)
    {
        return (int)Math.Abs(x-r) + (int)Math.Abs(y-c);
    }
    
    public void DFS(int x, int y, int movedDist, int k)
    {
        if(answer != "") return;
        // 이동해야할 거리가 k보다 더 긴 경우
        if(movedDist + GetDist(x, y, targetX, targetY) > k) return;
        if(k == movedDist) // 이동 거리가 k가 되면 answer
        {
            answer = sb.ToString();
            return;
        }
        
        for(int i = 0; i < 4; i++)
        {
            int newX = x + dx[i];
            int newY = y + dy[i];
            if (newX <= 0 || newY <= 0 || newX > n || newY > m) continue;
            
            // DFS + back tracking
            sb.Append(dir[i]);
            DFS(newX, newY, movedDist + 1, k);
            sb.Remove(movedDist, 1);
        }
    }
}