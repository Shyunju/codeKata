public class Solution {
    public string solution(string phone_number) {
        string answer = phone_number.Substring(phone_number.Length -4);
        answer = answer.PadLeft(phone_number.Length, '*');
        return answer;
    }
}