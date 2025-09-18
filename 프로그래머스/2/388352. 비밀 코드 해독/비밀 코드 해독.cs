using System;
using System.Collections.Generic;
public class Solution {
    static int answer = 0;
    static int[] arr;  //사용 가능한 정수들의 배열
    public int solution(int n, int[,] q, int[] ans) {
        arr = new int[n];
        for(int i=0; i<n; i++)
        {
            arr[i] = i+1; //1~n 까지의 숫자들을 넣어줌
        }
        List<int> iList = new List<int>();
        comb(n, q, ans, 0, iList);
        return answer;
    }
    
    public void comb(int n, int[,] q, int[] ans, int cur, List<int> list) {
        if(list.Count == 5) 
        {
            if(isPossible(q, ans, list)) answer++;
            return;
        }
        
        for(int i = cur; i < n; i++) 
        {
            list.Add(arr[i]);
            comb(n, q, ans, i+1, list);
            list.RemoveAt(list.Count - 1);  //가장 마지막에 추가한 요소 삭제 = 지금 넣은 숫자 삭제
        }
    }
    
    public bool isPossible(int[,] q, int[] ans, List<int> list) {  //list는 현재 비교할 조합
        for(int i=0; i < q.GetLength(0); i++) 
        {
            int cnt = 0;
            for(int j = 0; j < q.GetLength(1); j++)
            {
                for(int k = 0; k < list.Count; k++) 
                {
                    if(q[i,j] == list[k])
                    {
                        cnt++;
                        //break;
                    }
                }
            }
            
            if(cnt != ans[i]) 
                return false;
        }
        return true;
    }
}