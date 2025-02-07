public class Solution {
    public string solution(string[] seoul) {
        //string answer = "";
        int kim = 0;
        for(int i =0; i < seoul.Length ; i++){
            if(seoul[i] == "Kim"){
                kim = i;
            }
        }
        return string answer = "김서방은 "+ kim.ToString() + "에 있다";
    }
}