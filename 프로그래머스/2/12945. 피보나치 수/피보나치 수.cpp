#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    vector<int> fibo;
    fibo.push_back(1);
    fibo.push_back(1);
    while(fibo.size() < n){
        fibo.push_back((fibo[fibo.size()-1] + fibo[fibo.size() -2]) % 1234567);
    }
    return fibo[fibo.size()-1];
}