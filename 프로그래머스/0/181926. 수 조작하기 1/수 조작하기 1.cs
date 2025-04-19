using System;

public class Solution {
    public int solution(int n, string control) {
        foreach(char i in control)
        {
            switch(i)
            {
                case 'w':
                    n += 1;
                    break;
                case 's':
                    n -= 1;
                    break;
                case 'd':
                    n += 10;
                    break;
                case 'a':
                    n -= 10;
                    break;
                default :
                    break;
            }
        }
        return n;
    }
}