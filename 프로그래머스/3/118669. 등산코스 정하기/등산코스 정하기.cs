using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static int[] dist = new int[50001]; // 각 노드의 최소 intensity
    static List<List<int>>[] node = new List<List<int>>[50001]; // 연결 노드 정보
    static bool[] isTop = new bool[50001]; // 그 노드가 산봉우리인지 체크
    static int[] ans = new int[2]{-1,-1}; // 정답 배열
    
    // 정렬 기준
    public class MyCompare : IComparer<List<int>>
    {
        // intensity 기준 내림차순 정렬
        public int Compare(List<int> x, List<int> y)
        {
            if (x[0] == y[0]) return y[1]-x[1];
            return y[0]-x[0];
        }
    }
    
    public static void Dijkstra(int[] gates)
    {   
        // 우선순위 큐가 없으므로 SortedSet으로 비슷하게 흉내냄
        // intensity가 작을수록 앞으로 오도록 설정
        SortedSet<List<int>> q = new SortedSet<List<int>>(new MyCompare());
        
        // 모든 출발지점 큐에 넣음
        foreach (int gate in gates)
        {
            q.Add(new List<int>() { 0, gate }); // (intensity, 번호)
            dist[gate] = 0; //출발지점 = 0
        }

        while (q.Count > 0)
        {
            List<int> cnt = q.First(); // 가장 앞에 있는 것
            q.Remove(cnt); // SortedSet 가장 앞에있는 원소 삭제

            int x = cnt[1]; // 현재 노드
            int cost = cnt[0]; // 그 노드에 저장된 intensity
			// 비용이 현재 그 dist배열에 저장된 최소거리보다 크다면 패스
            if (cost > dist[x]) continue;
            
            // ans에 값이 있고 최소 intensity가 현재 노드의 intensity보다 작은 경우
            if (ans[0] != -1 && ans[1] < cost) continue;
            
            // 해당 노드가 산봉우리인 경우
            if (isTop[x])
            {
            	// 답에 저장된 Intensity보다 작은 경우
                if(ans[0] == -1 || ans[1] > cost){
                	// 답 갱신
                    ans[0] = x;
                    ans[1] = cost;
                }
                // intensity는 같은데 번호가 더 빠른 경우
                else if(ans[1] == cost && ans[0] > x) ans[0] = x;
                continue;
            }
            // 현재 노드와 연결된 모든 노드 탐색
            for (int i = 0; i < node[x].Count; i++)
            {
                int next = node[x][i][0];
                int nCost = node[x][i][1]; // 그 노드로 가는 비용
				
                // cost와 그 노드로 가는 비용 중 더 큰 것이 저장된 dist보다 작은 경우
                if (dist[next] == -1 || Math.Max(cost, nCost) < dist[next])
                {	
                	// dist 갱신하고 q에 넣음
                    dist[next] = Math.Max(cost, nCost);
                    q.Add(new List<int>() { dist[next], next });
                }
            }
        }
    }

    public int[] solution(int n, int[,] paths, int[] gates, int[] summits)
    {
        Array.Fill(dist, -1); // dist -1로 초기화
        // 노드 초기화
        for (int i = 0; i <= n; i++) node[i] = new List<List<int>>();
        foreach (int summit in summits) isTop[summit] = true;
        
        // 노드 연결
        for (int i = 0; i < paths.GetLength(0); i++)
        {
            int n1 = paths[i, 0];
            int n2 = paths[i, 1];
            int cost = paths[i, 2];

            node[n1].Add(new List<int>() { n2, cost });
            node[n2].Add(new List<int>() { n1, cost });

        }
        Dijkstra(gates);

        return ans;
    }
}