#include <bits/stdc++.h>
using namespace std;
//using System;
//using System.Collections.Generic;
vector<vector<int>> combs;
void dfs(int remain, vector<int> cur, int idx){
    if(remain == 0){
        combs.push_back(cur);
        return;

    }

    for(int i = idx; i<cur.size(); i++){
        cur[i]++;
        dfs(remain - 1, cur, i);
        cur[i]--;
    }
}

int simulation(vector<int> comb, vector<vector<int>> reqs){
    int wait = 0;

    priority_queue<int, vector<int>, greater<int>> pq[comb.size()];

    for(int i = 1; i<comb.size(); i++){
        for(int j = 0; j<comb[i]; j++) pq[i].push(0);
    }

    for(auto req : reqs){
        int start = req[0];
        int duration = req[1];
        int type = req[2];

        int last = pq[type].top();
        pq[type].pop();

        if(last > start){
            wait += last - start;
            pq[type].push(last + duration);
        }else if(start > last){
            pq[type].push(start + duration);
        }else{
            pq[type].push(last + duration);
        }
    }
    return wait;

}
int solution(int k, int n, vector<vector<int>> reqs) {

    int answer = INT_MAX;

    vector<int> c(k+1, 1);

    dfs(n-k, c, 1);

    for(auto comb : combs){

        answer = min(simulation(comb, reqs), answer);
    }

    return answer;
}
