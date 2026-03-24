using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();

        if (!int.TryParse(reader.ReadLine(), out int t)) return;

        while (t-- > 0)
        {
            int k = int.Parse(reader.ReadLine());
            
            // PriorityQueue<값, 우선순위>
            // 최소 힙 (오름차순)
            var minHeap = new PriorityQueue<int, int>();
            // 최대 힙 (내림차순 - 비교자를 직접 넣어 안전하게 처리)
            var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            
            var counts = new Dictionary<int, int>();
            int validCount = 0; // 실제 큐에 들어있는 유효한 숫자의 개수

            for (int i = 0; i < k; i++)
            {
                string[] input = reader.ReadLine().Split();
                char cmd = input[0][0];
                int num = int.Parse(input[1]);

                if (cmd == 'I')
                {
                    minHeap.Enqueue(num, num);
                    maxHeap.Enqueue(num, num);
                    
                    if (counts.ContainsKey(num)) counts[num]++;
                    else counts[num] = 1;
                    
                    validCount++;
                }
                else // cmd == 'D'
                {
                    if (validCount == 0) continue;

                    // 핵심: 삭제하기 전, 각 힙의 머리(Top)가 이미 다른 쪽에서 지워진 '유령'인지 먼저 확인
                    if (num == 1) CleanHeap(maxHeap, counts);
                    else CleanHeap(minHeap, counts);

                    // 이제 힙의 머리는 확실히 유효한 값이므로 삭제 진행
                    var targetHeap = (num == 1) ? maxHeap : minHeap;
                    if (targetHeap.Count > 0)
                    {
                        int target = targetHeap.Dequeue();
                        counts[target]--;
                        validCount--;
                    }
                }
            }

            // 최종 출력 전에도 '유령' 데이터 청소
            CleanHeap(minHeap, counts);
            CleanHeap(maxHeap, counts);

            if (validCount == 0)
            {
                sb.AppendLine("EMPTY");
            }
            else
            {
                sb.AppendLine($"{maxHeap.Peek()} {minHeap.Peek()}");
            }
        }
        Console.Write(sb.ToString());
    }

    // 힙의 최상단 값이 실제로 존재하지 않는(이미 삭제된) 값이라면 계속 뽑아버리는 함수
    static void CleanHeap(PriorityQueue<int, int> heap, Dictionary<int, int> counts)
    {
        while (heap.Count > 0)
        {
            int top = heap.Peek();
            if (counts.ContainsKey(top) && counts[top] > 0) break;
            heap.Dequeue(); // 유효하지 않은 값은 버림
        }
    }
}