using System;
using System.Linq;

public class Solution {
    public int solution(int order) {
        int answer = order.ToString().Count(x => x == '3' || x == '6' || x == '9');
        return answer;
    }
}