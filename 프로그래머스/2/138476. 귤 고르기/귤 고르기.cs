using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        //1. 배열을 정렬한다.
        // 비교할 변수하나를 생성한다. int n=0
        int n=0;
        int count=1;
        List<int> list = new List<int>(10000000);
        Array.Sort(tangerine);
        //2. 배열의 길이만큼 반복
        for(int i=0;i<tangerine.Length;i++)
        {
            //3. 인덱스와 n 이 같은지 비교
						//4. 같으면 n= 해당 인덱스의 인수, count++
            //5. 다르면 n=해당 인덱스의 인수 종류수를 저장하는 리스트에 저장 
            if(n==tangerine[i])
            {
                count++;
            }
            else
            {
                //만약 인덱스의 첫번째라면 그냥 넘긴다.
                if(tangerine[i]==0) continue;
                list.Add(count);
                count=1;
            }
            n=tangerine[i];
        }
        //끝나면 마지막 count를 list에 저장
        list.Add(count);
				// 리스트를 정렬한다. 
        list.Sort();
        list.Reverse();
        foreach(int i in list)
        {
            Console.Write(i);
        }
				// 리스트에 저장된 값만큼 반복
        foreach(int index in list)
        {
						// k에 더이상 뺄것이 없다면 for문 벗어난다.
            if (k<=0) break;
            answer++;
            k-=index; 
        }
        return answer;
    }
}