#include <string>
#include <vector>
using namespace std;

int solution(int coin, vector<int> cards) {
    // 대충 1000^2 안에 해결
    int targetNum=cards.size()+1, firstCardNum=cards.size()/3, round=1, combiNum=0, specialCase=0;
    for (int i=0; i<firstCardNum-1; i++)
    {
        for (int j=i+1; j<firstCardNum; j++)
        {
            if (cards[i]+cards[j]==targetNum)
            {
                combiNum+=1;
                break;
            }
        }
    }
    for (int i=firstCardNum; i<cards.size(); i+=2)
    {
        for (int j=0; j<i; j++)
        {
            if (j<firstCardNum)
            {
                if (cards[i]+cards[j]==targetNum&&coin>=1)
                {
                    combiNum+=1;
                    coin-=1;
                }
                if (cards[i+1]+cards[j]==targetNum&&coin>=1)
                {
                    combiNum+=1;
                    coin-=1;
                }
            }
            else // 코인을 두개 사용해야하는 경우
            {
                if (cards[i]+cards[j]==targetNum)
                {
                    specialCase+=1;
                }
                if (cards[i+1]+cards[j]==targetNum)
                {
                    specialCase+=1;
                }
            }            
        }
        // 예외처리
        if (cards[i]+cards[i+1]==targetNum)
        {
            specialCase+=1;
        }
        if (combiNum>0)
        {
            round+=1;
            combiNum-=1;
        }
        else{
            if (specialCase>0&&coin>=2)
            {
                specialCase-=1;
                round+=1;
                coin-=2;
            }
            else
            {
                break;
            }
        }
    }
    return round;
}