#include <string>
#include <vector>
#define MAX 100001

using namespace std;

int answer = 0;
bool isLightOn[MAX] = {0}; // 불이 켜진 등대인지 체크

void dfs(int node, int parent, vector<vector<int>> &info) {
    for (int i=0; i<info[node].size(); i++) {
        if (info[node][i] != parent) {
            dfs(info[node][i], node, info);
            
            // 자식과 부모 등대 모두 불이 꺼져 있다면 부모 등대 불 켜주기
            if (!isLightOn[info[node][i]] && !isLightOn[node]) {
                isLightOn[node] = true;
                answer++;
            }
        }
    }
}

int solution(int n, vector<vector<int>> lighthouse) {
    vector<vector<int>> info(n+1);
    
    for (int i=0; i<lighthouse.size(); i++) {
        info[lighthouse[i][0]].push_back(lighthouse[i][1]);
        info[lighthouse[i][1]].push_back(lighthouse[i][0]);
    }
    
    // 트리이기 때문에 1부터 시작
    dfs(1, 1, info);
    
    return answer;
}