#include <string>
#include <vector>
#include <iostream>

using namespace std;

vector<vector<int>> dp(1001, vector<int>(51, 100000000));
int initTmpt, _t1, _t2, _a, _b, answer = 10000000;

void dfs(vector<int>& onboard, int idx, int curTmpt, int cost)
{
    if (idx == onboard.size())
    {
        answer = min(answer, cost);
        return;
    }
    
    if (onboard[idx] == 1  && (curTmpt < _t1 || curTmpt > _t2))
        return;
    
    if (dp[idx][curTmpt] <= cost )
        return;

    dp[idx][curTmpt] = cost ;
    
    // 에어컨 끄기
        dfs(onboard, idx + 1, min(initTmpt, curTmpt + 1), cost);
    // 에어컨 유지
        dfs(onboard, idx + 1, curTmpt, cost + _b);
    // 에어컨 켜기'
        dfs(onboard, idx + 1, curTmpt - 1, cost + _a);
}

int solution(int temperature, int t1, int t2, int a, int b, vector<int> onboard) {
    initTmpt = temperature ;
    _t1 = t1 ;
    _t2 = t2;
    _a = a;
    _b = b;
    
    if (initTmpt < _t1)
        initTmpt = _t2 + (_t1 - initTmpt);
    
    dfs(onboard, 0, initTmpt, 0);

    return answer;
}