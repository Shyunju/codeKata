#include <string>
#include <vector>

using namespace std;

int solution(int n, int t) {
    for(int i = 0; i < t; i++){
        n += n;
    }
    return n;
}