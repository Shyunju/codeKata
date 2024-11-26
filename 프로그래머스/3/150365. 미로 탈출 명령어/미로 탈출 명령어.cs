using System;
using System.Text;
public class Solution {
    public enum EDirType { d= 0, l=1, r=2, u=3}
    public int GetMinDis(int x, int y, int r, int c) => Math.Abs(x-r) + Math.Abs(y-c);
    public string solution(int n, int m, int x, int y, int r, int c, int k) {
        if(GetMinDis(x, y, r, c) > k || (GetMinDis(x,y,r,c) % 2 != 0 && k % 2 == 0)) return "impossible";
        StringBuilder sb = new StringBuilder();
        
        int[] dirY = new int[4] { 0, -1, 1, 0};
        int[] dirX = new int[4] {1, 0, 0, -1};
        
        while(k != GetMinDis(x,y,r,c)){
            k--;
            for(int i = 0; i < 4; i++){
                int moveX = x + dirX[i];
                int moveY = y + dirY[i];
                
                if(moveX >= 1 && moveX <= n && moveY >= 1 && moveY <= m){
                    x = moveX;
                    y = moveY;
                    sb.Append(((EDirType)i).ToString());
                    break;
                }
            }
        }
        while(x < r) { sb.Append('d'); x++;}
        while(y > c) { sb.Append('l'); y--;}
        while(y < c) { sb.Append('r'); y++;}
        while(x > r) { sb.Append('u'); x--;}
        return sb.ToString();
    }
}