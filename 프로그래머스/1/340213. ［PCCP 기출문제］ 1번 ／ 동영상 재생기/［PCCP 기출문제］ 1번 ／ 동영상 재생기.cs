using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        string answer = "";
        //시간을 분 * 100, 초 로 합산하여 보관하기
        int video = int.Parse(video_len.Substring(0,2)) * 100 + int.Parse(video_len.Substring(video_len.Length - 2));
        int cur = int.Parse(pos.Substring(0,2)) * 100 + int.Parse(pos.Substring(pos.Length - 2));
        int opS = int.Parse(op_start.Substring(0,2)) * 100 + int.Parse(op_start.Substring(pos.Length - 2));
        int opE = int.Parse(op_end.Substring(0,2)) * 100 + int.Parse(op_end.Substring(pos.Length - 2));

        //현재 재생 구간이 오프닝 시가과 끝 사이라면 끝으로 이동
        if(cur >= opS && cur < opE)
                cur = opE;
        //명령에 따라 분기하기
        for(int i = 0; i < commands.Length; i++){
            if(commands[i] == "next"){
                cur += 10;
                if(cur % 100 >= 60){
                    cur += 100;
                    cur -= 60;
                }
                if(cur > video)
                    cur = video;              
            }
            if(commands[i] == "prev"){
                if(cur % 100 < 10){
                    cur -= 50;
                }else
                    cur -= 10;
                if(cur < 0)
                    cur = 0;
            }
            if(cur >= opS && cur < opE)
                cur = opE;
        }
        //prev - +10 이때 % 100 이 60이상이면 +100 -60 이때에도 예외발생 염려
        //의 결과가 영상길이보다 크다면 영상길이로 대체
        
        //next - -10 이때 % 100 이 10보다 작다면 -40더 ex  02초 상황이면 92초가 될테니 -40면 52초로 정상화
        //의 결과가 0보다 작다면 0으로 대체
            
        //이걸 코멘트 길이만큼 반복
        
        //분과 초를 /100 %100으로 분리
        int result_mm = cur / 100;
        int result_ss = cur % 100;
        
        string answer_mm = result_mm < 10 ? "0" + result_mm : result_mm.ToString();
        string answer_ss = result_ss < 10 ? "0" + result_ss : result_ss.ToString();
        //둘다 10보다 작다면 문자열 0과 합산
        //중간에 콜론과 함께 반환
        
        
        return answer_mm + ":" + answer_ss;
    }
}