using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string[] solution(string[] s) {
        string[] answer = new string[s.Length];
        for(int i = 0; i < s.Length; i++){
            answer[i] = Change(s[i]);
        }
        return answer;
    }
    private string Change(string str){
        if(str.Length < 3) return str;
        
        var stack = new Stack<char>();
        int cnt = 0;
        for(int i = 0; i < str.Length; i++){
            if(stack.Count < 2){
                stack.Push(str[i]);
                continue;
            }
            if(str[i] == '0'){
                char c = stack.Pop();
                if(c == '1' && stack.Peek() == '1'){
                    cnt++;
                    stack.Pop();
                    continue;
                }
                stack.Push(c);
            }
            stack.Push(str[i]);
        }
        var list = stack.ToList();
        list.Reverse();
        
        int oneCnt = 0;
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < list.Count; i++){
            if(list[i] == '1'){
                oneCnt++;
                continue;
            }
            for(int j = 0; j < oneCnt; j++){
                sb.Append("1");
            }
            oneCnt = 0;
            sb.Append("0");
        }
        for(int i = 0; i < cnt; i++){
            sb.Append("110");
        }
        for(int i = 0; i < oneCnt; i++){
            sb.Append("1");
        }
        return sb.ToString();
    }
}
//한글자씩스택에 넣어 110을 찾아 없애고 갯수를 기록한다
//남은 문자열에서 마지막에 있는 0 뒤로 110을 모두 붙이고 남은 1을 붙여 반환한다