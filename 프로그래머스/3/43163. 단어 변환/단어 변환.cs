using System;

public class Solution {
    string tar;
    int answer = 0;
    
    //dfs
    //비교 항목, 단계, 방문 여부, 비교 대상 배열
    public void dfs(string begin, int phase, bool[] visit, string[] words)
    {
        //비교 대상 길이만큼 반복
        for(int i=0; i<words.Length; i++)
        {
            //해당 visit 변수가 거짓이면
            if(!visit[i])
            {
                //비교 항목과 [i]번째 비교 대상 단어와 비교
                int n = 0;
                for(int j=0; j<words[i].Length; j++)
                {
                    //한 글자씩 비교하여 같으면 n변수 더하기
                    if(begin[j]==words[i][j])
                    {
                        n++;
                    }
                }
                //변수 n이 비교 항목 문자열 길이 - 1 과 같을 때
                if(n==begin.Length-1)
                {
                    //비교 항목을 새로운 비교 대상 단어로 치환
                    begin = words[i];
                    //해당 번째 방문 true
                    visit[i]=true;
                    
                    //치환된 비교 항목이 목표 타겟과 같으면 dfs 종료
                    if(begin==tar)
                    {
                        answer = phase + 1;
                    }
                    //아니면 dfs 실행
                    else
                    {
                        dfs(begin, phase + 1, visit, words);
                    }
                }
            }
        }
    }
    
    public int solution(string begin, string target, string[] words) {
        //목표 타겟 변수 저장
        tar = target;
        
        //방문 변수 선언
        bool[] visit = new bool[words.Length];
        
        //dfs 실행
        dfs(begin, 0, visit, words);
        
        return answer;
    }
}