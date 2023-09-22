using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        int[] a = new int[10];
        int[] b = new int[10];

        for(int i = 0; i < X.Length; i++)
        {
            a[(int)(X[i] - 48)]++;
        }
        for(int i = 0; i < Y.Length; i++)
        {
            b[(int)(Y[i] - 48)]++;
        }
        StringBuilder sb = new StringBuilder();

        for(int i = 9; i >= 0; i--)
        {
            while(a[i] > 0 && b[i] > 0){
                sb.Append(i);
                a[i]--;
                b[i]--;
            }
        }
        if("".Equals(sb.ToString()))
        {
            answer = "-1";
        }
        else if("0".Equals(sb.ToString().Substring(0, 1)))
        {
            answer = "0";
        }
        else
        {
            answer = sb.ToString();
        }

        return answer;
    }
}