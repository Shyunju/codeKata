using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int k, int[] enemy) 
    {
        if(k >= enemy.Length)
            return enemy.Length;

        var q = new PriorityQueue();

        int i = 0;
        for(; i < k; ++i) // 미리 k개를 사용한다.
            q.Push(enemy[i]);

        // 순회하면서 최소값보다 크면 교체하고 재정렬한다.
        for(; i < enemy.Length; ++i)
        {
            int cur = enemy[i];
            if(q.Peek() < cur)
            {
                n -= q.Pop(); // 무적권으로 사용되지 않은 병력 지불
                q.Push(cur);
            }
            else
            {
                n -= cur;
            }

            if(n < 0)
                return i;
        }

        return enemy.Length;
    }
}

public class PriorityQueue{
    List<int> heap = new List<int>();

    public void Push(int data)
    {
        heap.Add(data); // 맨 끝에 데이터 삽입

        int now = heap.Count - 1; // 데이터를 삽입한 맨 끝 index

        while(now > 0)
        {
            int parent = (now - 1) / 2; // 부모노드
            if(heap[now] > heap[parent]) // 부모 노드와 비교
                break;

            int temp = heap[now];
            heap[now] = heap[parent];
            heap[parent] = temp;

            // 부모로 이동한다.
            now = parent;
        }
    }

    public int Pop() // 루트노드 (최솟값)
    {
        int ret = heap[0]; // 반환할 데이터를 별도 저장

        // 마지막 위치에 있던 데이터를 임시로 루트로 이동시킨다.
        int lastIndex = heap.Count - 1; 
        heap[0] = heap[lastIndex];
        heap.RemoveAt(lastIndex);
        lastIndex--;

        // 아래로 스왑해가면서 정렬한다.
        int now = 0;
        while(true)
        {
            int left = 2 * now + 1;
            int right = 2 * now + 2;

            int next = now;

            // 왼쪽 값이 현재값보다 작으면, 왼쪽으로 이동
            if(left <= lastIndex && heap[next] > heap[left])
                next = left;

            // 오른쪽 값이 현재값보다 작으면, 오른쪽으로 이동
            if(right <= lastIndex && heap[next] > heap[right])
                next = right;

            // 왼쪽 오른쪽 모두 현재값보다 크면 종료
            if(next == now)
                break;

            int temp = heap[now];
            heap[now] = heap[next];
            heap[next] = temp;

            // 검사 위치로 이동
            now = next;
        }

        return ret;
    }

    public int Peek()
    {
        return heap[0];
    }
}