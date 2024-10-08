#include <string>
#include <vector>
#include <queue>

using namespace std;
const int MAX = 1000000000;
vector<pair<int, int>> dp;

// priority_queue용 비교 함수
struct compare
{
    bool operator()(pair<int, int>& a, pair<int, int>& b)
    {
        if (a.first == b.first)
            return a.second < b.second;
        return a.first > b.first;
    }
};

// pair 더해주는 함수
pair<int, int> ADD_PAIRS(pair<int, int>a, pair<int, int>b)
{
    return {a.first + b.first, a.second + b.second};
}

pair<int, int> DFS(int target)
{ // 끝에 도달했다면 return
    if (target == 0)
        return {0, 0};
    
    // 이미 계산된 적이 있다면 return
    if (dp[target].first > 0)
        return dp[target];
    
    // 모든 경우의 수 중 최적의 수를 찾기 위한 priority_queue
    // 단순 계산해도 상관X
    priority_queue<pair<int, int>, vector<pair<int, int>>, compare> q;
    
    // 트리플 +  60 이상의 큰 수
    if (target > 20)
    {	// 60 보다 작으면 트리플 맞춰서 남은 수, 크면 - 60
        int next = target <= 60 ? target % 3 : target - 60;
        q.push(ADD_PAIRS(DFS(next), {1, 0}));
    }
    
    // 더블
    if (target > 20 && target <= 40)
        q.push(ADD_PAIRS(DFS(target % 2), {1, 0}));
    
    // 볼
    if (target >= 50)
       q.push(ADD_PAIRS(DFS(target - 50), {1, 1}));
    
    // 싱글
    int next = max(0, target - 20);
    q.push(ADD_PAIRS(DFS(next), {1, 1}));

	// 최적의 값을 저장
    return dp[target] = q.top();
}

vector<int> solution(int target) {
    dp.resize(target+1, {-1, -1});
    DFS(target);
    return {dp[target].first, dp[target].second};
}