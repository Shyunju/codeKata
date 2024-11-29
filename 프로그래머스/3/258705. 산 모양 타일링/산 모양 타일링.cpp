#include <string>
#include <vector>
#include <iostream>

using namespace std;

int per = 10007;
int visited[200005]={0,};
int dp[200005]={0,};

int solution(int n, vector<int> tops) {
int answer = 0;
for(int i=0; i<tops.size(); i++){
	if(tops[i] == 1){
		visited[i*2 +1] = 1;
	}
}

dp[0] =1;
dp[1] = 2;

if(visited[1] ==1){
	dp[1] = 3;
}

for(int j =2; j<=2*n; j++){
	// index가홀수이고 위 삼각형이 있을때.
	if(j%2 == 1 && visited[j] == 1){ 
		dp[j] = dp[j-1] + dp[j-1] + dp[j-2];
	}else{
	
    //짝수
	dp[j] = dp[j-1] + dp[j-2];
	}
	dp[j] %= 10007;
}

answer = dp[2*n];
return answer;
}
