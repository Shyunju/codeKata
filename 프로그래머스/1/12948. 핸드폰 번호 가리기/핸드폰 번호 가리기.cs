public class Solution {
    public string solution(string phone_number) {
        string number = phone_number.Substring(phone_number.Length - 4);
        string star = "";
        for(int i = 0; i < phone_number.Length-4; i++){
            star += "*";
        }
        return star + number;
    }
}