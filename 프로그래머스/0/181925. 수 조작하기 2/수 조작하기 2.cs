using System;
using System.Text;
public class Solution {
    public string solution(int[] numLog) {
        StringBuilder sb = new StringBuilder();
        int cur = numLog[0];
        for(int i = 1; i < numLog.Length; i++)
        {
            switch(numLog[i] - cur)
            {
                case 1:
                    sb.Append("w");
                    break;
                case -1:
                    sb.Append("s");
                    break;
                case 10:
                    sb.Append("d");
                    break;
                case -10:
                    sb.Append("a");
                    break;
                default:
                    break;
            }
            cur = numLog[i];
        }
        return sb.ToString();
    }
}