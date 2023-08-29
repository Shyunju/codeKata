public class Solution {
    public string solution(string phone_number) {
        char[] charArray = phone_number.ToCharArray();
        for(int i = 0; i< charArray.Length-4; i++){
            charArray[i] ='*';
        }
        string result = new string(charArray);
        return result;
    }
}