public class Solution {
    public string solution(int a, int b) {
        string[] day = new string[] {"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        int[] days = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int total = --b;
        for(int i = 0 ; i < a-1; i++){
            total += days[i];
        }
        string answer = day[total % 7];
        return answer;
    }
}