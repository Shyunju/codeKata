using System;
using System.Collections.Generic;

public class Solution {
    
    string result;
    bool[] visit;
    
    void dfs(string[,] tickets, string cur, string path, int len)
    {
        //티켓 갯수랑 len길이랑 같으면 끝
        if(len==tickets.GetLength(0))
        {
            result = path;
            return;
        }
        
        for(int i=0; i<tickets.GetLength(0); i++)
        {
            //방문하지 않은 상태이면서 티겟이 다음 티켓이랑 같으면 항공권이 있다는 의미
            if(!visit[i] && tickets[i,0].Equals(cur))
            {
                //이어서 dfs
                visit[i] = true;
                dfs(tickets, tickets[i,1], path + tickets[i,1], len+1);
                visit[i]=false;
            }
        }
    }
    
    public string[] solution(string[,] tickets) {
        
        visit = new bool[tickets.GetLength(0)];
        List<string> list = new List<string>();
        
        //알파벳 순서 대로 정렬
        for(int i=0; i<tickets.GetLength(0)-1; i++)
        {
            for(int j=i+1; j<tickets.GetLength(0); j++)
            {
                //문자형으로 비교하면 오류
                //string.Compare로 진행
                if(string.Compare(tickets[i,1], tickets[j,1])==-1)
                {
                    string[][] tmp = new string[][] 
                    {
                        new string [] {tickets[i,0], tickets[i,1]}
                    };
                    tickets[i,0] = tickets[j,0];
                    tickets[i,1] = tickets[j,1];
                    tickets[j,0] = tmp[0][0];
                    tickets[j,1] = tmp[0][1];
                }
            }
        }
        
        //dfs 함수
        dfs(tickets, "ICN", "ICN", 0);
        
        //모든 공항이 3글자 이므로 3글자씩 끊어서 리스트 추가
        for(int i=0; i<result.Length; i+=3)
        {
            list.Add(result.Substring(i,3));
        }
        //리스트 배열화 하고 리턴
        string[] answer = list.ToArray();
        return answer;
    }
}