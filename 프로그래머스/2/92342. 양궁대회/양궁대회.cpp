#include <string>
#include <vector>

using namespace std;

int arr[11];
int max_diff = 0;
vector<int> answer = { -1 };
vector<int> ryan={0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

int cmp(vector<int> ryan, vector<int> apeach) {
    int ryan_score = 0;
    int apeach_score = 0;

    for (int i = 0; i < 11; i++) {
        if (ryan[i] > apeach[i]) {
            ryan_score += 10 - i;
        }
        else {
            if (apeach[i] != 0) {
                apeach_score += 10 - i;
            }
        }
    }

    return ryan_score - apeach_score;
}

// 중복 조합을 이용해 라이언 배열 얻기
void shooting(int conut, int num, int draw, vector<int> ryan, vector<int> apeach) {
    if (conut == draw) {
        vector<int> tmp;
        for (int i = 0; i < draw; i++) {
            tmp.push_back(arr[i]);
        }

        for (int i = 0; i < draw; i++) {
            ryan[10 - tmp[i]]++;
        }

        int diff = cmp(ryan, apeach);

        if (diff > max_diff) {
            max_diff = diff;
            answer = ryan;
        }

        return;
    }

    for (int i = num; i < 11; i++) {
        arr[conut] = i;
        shooting(conut + 1, i, draw, ryan, apeach);
    }
}

vector<int> solution(int n, vector<int> info) {
    //vector<int> ryan(11, 0);
    vector<int> apeach = info;

    shooting(0, 0, n, ryan, apeach);

    return ryan;
}